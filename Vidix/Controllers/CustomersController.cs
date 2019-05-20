using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidix.Models;
using Vidix.ViewModels;

namespace Vidix.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name= "John Smith" },
                new Customer {Name = "Mary Williams" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };
           
            return View(viewModel);
        }
    }
}