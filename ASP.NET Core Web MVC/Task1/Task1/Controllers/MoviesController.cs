using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class MoviesController:Controller
    {
        public IActionResult Index()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello from Index!!";
            result.ContentType = "text/Html";
            result.StatusCode = 200;

            return result;
        }

        public IActionResult GoGoogle()
        {
            RedirectResult result = new RedirectResult("https://www.google.com");
            return result;
        }

        public IActionResult GetMovies(int? id)
        {
            if ( id == 0)
            {
                return BadRequest();
            }
            else if (id <= 10)
            {
                return NotFound();
            }
            else
            {
                return Content($"$Movies ID = {id}");
            }
        }

        public IActionResult GetMoviesByName(int Id , string name)
        {
            return Content($"$Movies ID = {Id} and Name = {name}");
        }

        public IActionResult AddMovie(Movie movie)
        {
            return Content($"$Movies ID = {movie.Id} and Name = {movie.Title}");
        }

    }
}
