using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vuelos.Models
{
    public class Vuelos 
    {
        [Key]
        public int Id { get; set; }

        [Required , StringLength(255), Display(Name = "Numero de vuelo")]
        public string NumVuelo { get; set; }

        [Required, Display(Name = "Horario de llegada"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm}")]
        public DateTime HorarioLlegada { get; set; }

        [Required, Display(Name = "Linea Aerea")]
        public string LineaArea { get; set; }

        public bool Demorado { get; set; }
       
    }
}