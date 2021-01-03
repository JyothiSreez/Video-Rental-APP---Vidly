using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;

namespace Vidly1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers


        public ActionResult Index()
        {
                
            var customers = new List<Customers>

            {

                new Customers { Id = 1, Name = "John Smith" },
                new Customers { Id = 2, Name = "Mary Williams" }
            };


            var viewModel = new DetailsCustomerViewModel
            {
                Customers = customers


            };

            return View(viewModel);
        }



        public ActionResult Details()
        {


            var customers = new List<Customers>
            {

            new Customers { Id = 1, Name = "John Smith" },
            new Customers { Id = 2, Name = "Mary Williams" }

           
            };
            

            if (!customers.Any())
                return HttpNotFound();

            var viewModel = new DetailsCustomerViewModel
        
            {
                Customers = customers

            };
            

            return View(viewModel);



    }

}
}

