using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private MyDBContext  _context { get; set; }

        public MovieController()
        {
            _context = new MyDBContext();
        }
        protected override  void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult index(int? PageIndex, string SortBy)
        {


            var moviesList = _context.Movies.Include(m => m.genre).ToList();
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