using System;
using System.Collections.Generic;

#nullable disable

namespace ShyamBank.Models
{
    public partial class Account
    {
        public Account()
        {
            Customers = new HashSet<Customer>();
        }

        public int AccountNo { get; set; }
        public int Balance { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
