using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        List<Movie> movies = new List<Movie>
            {
                new Movie { Name = "Movie 1", Id=1 },
                new Movie { Name = "Movie 2", Id=2 }
            };

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Avengers" };

            return View(movie);
            // ViewData["Movie"] = movie; // do not use
            // ViewBag.Movie = movie; // do not use

            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page=1, sortBy = "name"});
        }

        public ActionResult Random2()
        {
            var movie = new Movie() { Name = "Avengers" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index2(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year:regex(\\d{4}):min(2021)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int id)
        {
            try
            {
                return View(movies[id - 1]);
            }
            catch
            {
                return HttpNotFound();
            }
        }
    }
}