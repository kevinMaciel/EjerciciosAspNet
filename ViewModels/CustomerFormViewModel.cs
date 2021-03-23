using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vydly2.Models;

namespace Vydly2.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}