using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vuelos.Models;

namespace Vuelos.Controllers
{
    public class BajaController : Controller
    {
        // GET: Baja

        public ApplicationDbContext _context;

        public BajaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Baja()
        {
            var vuelos = _context.Vuelos.ToList();
            return View(vuelos);
        }




    }
}