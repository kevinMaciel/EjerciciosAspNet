using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {//Borrar esta parte para probar cuando no hay elementos de la lista----------------
                new Customer() {Name = "Kevin"},
                new Customer() {Name = "Agustin"}
            //----------------------------------------------------------------------------------
            };
            var viewModel = new Customer
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            ViewBag.Name = id == 1 ? "Kevin Maciel" : "Nicolas Molina";



            return View();
        }



    }
}