using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidix.Models;

namespace Vidix.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customer Customer { get; set; }
    }
}