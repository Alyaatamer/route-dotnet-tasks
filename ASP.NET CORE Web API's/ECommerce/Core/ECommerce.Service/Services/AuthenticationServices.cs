using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Exceptions;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Shared.DTO_s.IdentityDto_s;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Services
{
    public class AuthenticationServices(UserManager<ApplicationUser> userManager, IConfiguration configuration) : IAuthenticationServices
    {
        public async Task<UserDto> LoginAsync(LoginDto Dto)
        {
            var User = await userManager.FindByEmailAsync(Dto.Email) ?? throw new UserNotFoundException(Dto.Email);
            var IsPasswordValid = await userManager.CheckPasswordAsync(User, Dto.Password);

            if (IsPasswordValid)
            {
                return new UserDto
                {
                    Email = User.Email,
                    DisplayName = User.DisplayName,
                    Token = await CreateTokenAsync(User)
                };
            }
            else
            {
                throw new UnAutherizedException();
            }
        }

        public async Task<UserDto> RegisterAsync(RegisterDto Dto)
        {
            var user = new ApplicationUser()
            {
                DisplayName = Dto.DisplayName,
                Email = Dto.Email,
                UserName = Dto.UserName,
                PhoneNumber = Dto.PhoneNumber
            };

            var result = await userManager.CreateAsync(user, Dto.Password);

            if (result.Succeeded)
            {
                return new UserDto
                {
                    Email = user.Email,
                    DisplayName = user.DisplayName,
                    Token = await CreateTokenAsync(user)
                };
            }
            else
            {
                var Errors = result.Errors.Select(e => e.Description).ToList();
                throw new BadRequestException(Errors);
            }
        }

        private async Task<string> CreateTokenAsync(ApplicationUser user)
        {
            var Claims = new List<Claim>()
            {
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Name, user.UserName),
                new(ClaimTypes.NameIdentifier, user.Id),
            };
            var Roles = await userManager.GetRolesAsync(user);

            foreach (var Role in Roles)
            {
                Claims.Add(new Claim(ClaimTypes.Role, Role));
            }
            var SecurityKey = configuration.GetSection("JWTOptions")["SecurityKey"];

            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey));
            var Creds = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

            var Tokens = new JwtSecurityToken(
                issuer: configuration.GetSection("JWTOptions")["Issuer"],
                audience: configuration.GetSection("JWTOptions")["Audience"],
                claims: Claims,
                expires: DateTime.Now.AddDays(2),
                signingCredentials: Creds
            );

            return new JwtSecurityTokenHandler().WriteToken(Tokens);
        }
    }
}
