using ECommerce.Abstraction.IServices;
using ECommerce.Shared.DTO_s.IdentityDto_s;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController(IServicesManger servicesManger) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto dto)
        {
            var User = await servicesManger.AuthenticationServices.LoginAsync(dto);
            return Ok(User);
        }
        [HttpPost("Register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto dto)
        {
            var User = await servicesManger.AuthenticationServices.RegisterAsync(dto);
            return Ok(User);
        }
    }
}
