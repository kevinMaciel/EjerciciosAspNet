using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vuelos.Models;
using Vuelos.ViewModels;

namespace Vuelos.Controllers
{
    public class AltaController : Controller
    {

        public ApplicationDbContext _context;

        public AltaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Alta
        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Models.Vuelos vuelos)
        {
            

            if (vuelos.Id == 0)
            {
                _context.Vuelos.Add(vuelos);
            }
            else
            {
                var vuelosInDb = _context.Vuelos.Single(m => m.Id == vuelos.Id);
                vuelosInDb.NumVuelo = vuelos.NumVuelo;
                vuelosInDb.HorarioLlegada = vuelos.HorarioLlegada;
                vuelosInDb.LineaArea = vuelos.LineaArea;
                vuelosInDb.Demorado = vuelos.Demorado;
            }

            _context.SaveChanges();
            return RedirectToAction("Alta", "Alta");
        }
    }
}