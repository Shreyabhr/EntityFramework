﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEFFrameworkApp.Model
{
    class AurionproDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
    
}