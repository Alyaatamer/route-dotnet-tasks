using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
