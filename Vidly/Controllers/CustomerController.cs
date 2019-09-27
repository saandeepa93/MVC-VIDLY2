using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;


namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private MyDBContext _context;

        public CustomerController()
        {
            _context = new MyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Customer
        public ActionResult Index()
        {

            var lCust = _context.Customers.Include(c => c.memberShipType).ToList();
            return View(lCust);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c=>c.memberShipType).SingleOrDefault(c=>c.id == id);
            return View(customer);
        }
      
    }
}