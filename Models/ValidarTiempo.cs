using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vuelos.Models
{
    public class ValidarTiempo : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime result;
            bool parsed = DateTime.TryParse((string)value, out result);
            if (!parsed && DateTime.MinValue.TimeOfDay == result.TimeOfDay)
            {
                return new ValidationResult("ingresa una hora valida");
            }
            return ValidationResult.Success;
        }
    }
}