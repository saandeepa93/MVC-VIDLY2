using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Hollywood" };
            var customers = new List<Customer>
            {
                new Customer {id = 1, name = "Godfather"},
                new Customer {id = 2, name = "Lord of the Rings"}
            };

            var viewmodel = new RandomMovie
            {
                movie = movie,
                customer = customers
            };
            return View(viewmodel);
        }

        public ActionResult edit (int id)
        {
            return Content("id = " + id);
        }

        public ActionResult index(int? PageIndex, string SortBy)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;

            if (String.IsNullOrWhiteSpace(SortBy))
                SortBy = "Name";

            return Content(string.Format("Page Index = {0} and Sort By = {1}", PageIndex, SortBy));
        }

        [Route("movie/release/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}