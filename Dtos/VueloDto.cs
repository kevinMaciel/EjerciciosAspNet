using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vuelos.Dtos
{
    public class VueloDto
    {
        public int Id { get; set; }
        public string NumVuelo { get; set; }
        public string HorarioLlegada { get; set; }
        public string LineaArea { get; set; }
        public bool Demorado { get; set; }
    }
}