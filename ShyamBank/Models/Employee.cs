﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ShyamBank.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
