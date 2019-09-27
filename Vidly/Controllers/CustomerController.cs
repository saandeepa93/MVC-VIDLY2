using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;


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


        public ActionResult New()
        {
            var membershiptypes = _context.MembershipTypes.ToList();
            var newViewModel = new NewCustomerViewModel()
            {
                membershipTypes = membershiptypes
            };
            return View(newViewModel);
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

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if(customer.id==0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var custinDB = _context.Customers.Single(c => c.id == customer.id);
                custinDB.name = customer.name;
                custinDB.birthDate = customer.birthDate;
                custinDB.memberShipTypeId = customer.memberShipTypeId;
                custinDB.isSubscribedToNewsLetter = customer.isSubscribedToNewsLetter;
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index","Customer");
        }

        public ActionResult Edit(int id)
        {
            var cust = _context.Customers.SingleOrDefault(c => c.id == id);
            var editModel = new NewCustomerViewModel()
            {
                customer = cust,
                membershipTypes = _context.MembershipTypes.ToList()
            };

            return View("New", editModel);
        }
      
    }
}