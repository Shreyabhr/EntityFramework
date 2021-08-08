using Customers.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Repository
{
    public class AurionproDBContext : DbContext, IAurionproDBContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
