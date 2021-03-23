using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vydly2.Models;

namespace Vydly2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}