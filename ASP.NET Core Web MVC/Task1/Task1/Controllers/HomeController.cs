using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Movie movie = new Movie()
            //{
            //    Id = 1,
            //    Title = "Avengers"
            //};
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }


    }
}
