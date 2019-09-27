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
        
        

        public ActionResult index(int? PageIndex, string SortBy)
        {
            

            var moviesList = new List<Movie>()
            {
                new Movie {id = 1, name = "Shrek" },
                new Movie {id = 2,name = "Wall-E"}
            };



            //if (!PageIndex.HasValue)
            //    PageIndex = 1;

            //if (String.IsNullOrWhiteSpace(SortBy))
            //    SortBy = "Name";

            //return Content(string.Format("Page Index = {0} and Sort By = {1}", PageIndex, SortBy));
            return View(moviesList.ToList());
        }

        [Route("movie/release/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}