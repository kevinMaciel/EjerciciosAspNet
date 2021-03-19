using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }

    public class CustomersMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}