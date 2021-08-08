using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ConsoleEFApp.Models
{
    public class AurionproDBContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}