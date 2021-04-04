using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vuelos.Models;

namespace Vuelos.Controllers
{
    public class VuelosController : Controller
    {
        // GET: Vuelos
        public ApplicationDbContext _context;

        public VuelosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult index()
        {
            var vuelos = _context.Vuelos.ToList();
            return View(vuelos);
        }
    }
}