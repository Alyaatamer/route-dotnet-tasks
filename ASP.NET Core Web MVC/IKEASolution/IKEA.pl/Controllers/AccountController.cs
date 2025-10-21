using IKEA.DAL.Models.Auth;
using IKEA.pl.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.pl.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> user;

        public AccountController(UserManager<ApplicationUser> user)
        {
            this.user = user;
        }

        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = new ApplicationUser()
            {
                Email = model.Email,
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };

            var result = this.user.CreateAsync(user, model.Password).Result;

            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);

        }
        #endregion

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

          
            var userManger = user.FindByEmailAsync(model.Email).Result; 
       
            if (userManger != null)
            {
                var result = user.CheckPasswordAsync(userManger, model.Password).Result;
                if (result)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            return View(model);

        }
      
        #endregion
    }
}
