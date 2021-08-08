using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingInEntityFramework
{
    public class AurionproDBContext : DbContext
    {
       
        public DbSet<Dept> Depts { get; set; }

        public DbSet<Emp> Emps { get; set; }

        
    }
}
