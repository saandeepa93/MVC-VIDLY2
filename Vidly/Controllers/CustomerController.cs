using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            
            var lCust = GetCustomerDetails().ToList();
            return View(lCust);
        }

        public List<Customer> GetCustomerDetails()
        {
            return new List<Customer>
            {
                new Customer{id =1 , name = "Saandeep"},
                new Customer{id = 2, name = "Sujal"},
                new Customer{id=3,name="Sahana"},
                new Customer{id = 4,name="Praveen"}
            };
            
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomerDetails().SingleOrDefault(c=>c.id == id);
            return View(customer);
        }
      
    }
}