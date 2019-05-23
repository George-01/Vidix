using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidix.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }//Navigation property

        public byte MembershipTypeId { get; set; }//foreign Key

    }
}