using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vuelos.Models;

namespace Vuelos.Controllers
{
    public class ModificacionController : Controller
    {
        // GET: Modificacion
        
            public ApplicationDbContext _context;

            public ModificacionController()
            {
                _context = new ApplicationDbContext();
            }

            protected override void Dispose(bool disposing)
            {
                _context.Dispose();
            }

            // GET: Inicio
            public ActionResult Modificacion()
            {
                var vuelos = _context.Vuelos.ToList();
                return View(vuelos);
            }

        [HttpPost]
        public ActionResult Save(Models.Vuelos vuelos)
        {

            if (vuelos.Id == 0)
                _context.Vuelos.Add(vuelos);
            else
            {
                var vuelosInDb = _context.Vuelos.Single(c => c.Id == vuelos.Id);
                vuelosInDb.HorarioLlegada = vuelos.HorarioLlegada;
                vuelosInDb.LineaArea = vuelos.LineaArea;
                vuelosInDb.Demorado = vuelos.Demorado;
                vuelosInDb.NumVuelo = vuelos.NumVuelo;
            }

            _context.SaveChanges();
            return RedirectToAction("Modificacion","Modificacion");
        }


        public ActionResult Details(int id)
        {
            var vuelos = _context.Vuelos.SingleOrDefault(c => c.Id == id);

            if (vuelos == null)
                return HttpNotFound();

            

            return View(vuelos);
        }

    }
    }
