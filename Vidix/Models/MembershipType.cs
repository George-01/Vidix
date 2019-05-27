using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidix.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        //Create specific types to resolve magic numbers in the Age biz rule.
        public static readonly byte Unknown = 0;// set to read only to avoid accidental changes in the code
        public static readonly byte PayAsYouGo = 0;

    }
}