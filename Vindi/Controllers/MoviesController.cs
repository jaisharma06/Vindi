using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vindi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vindi.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            Movie randomMovie = new Movie() { id = 1, title = "Back To The Future", imdbRating = 9.0f, releaseYear= 1992 };
            return View(randomMovie);
        }
    }
}
