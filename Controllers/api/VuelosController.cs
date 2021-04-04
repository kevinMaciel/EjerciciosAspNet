using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vuelos.Models;

namespace Vuelos.Controllers.api
{
    public class VuelosController : ApiController
    {
        private ApplicationDbContext _context;

        public VuelosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpDelete]
        public void DELETE(int id)
        {
            var vuelosInDb = _context.Vuelos.SingleOrDefault(c => c.Id == id);

            if (vuelosInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Vuelos.Remove(vuelosInDb);
            _context.SaveChanges();
        }
    }
}
