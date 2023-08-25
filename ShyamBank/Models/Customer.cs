using System;
using System.Collections.Generic;

#nullable disable

namespace ShyamBank.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Pan { get; set; }
        public int? AccountNo { get; set; }

        public virtual Account AccountNoNavigation { get; set; }
    }
}
