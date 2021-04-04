using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vuelos.Models;

namespace Vuelos.Controllers
{
    public class InicioController : Controller
    {
        public ApplicationDbContext _context;

        public InicioController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Inicio
        public ActionResult Inicio()
        {
            var vuelos = _context.Vuelos.ToList();
            return View(vuelos);
        }
    }
}