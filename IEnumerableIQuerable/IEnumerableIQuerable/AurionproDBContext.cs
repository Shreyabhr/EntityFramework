using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableIQuerable
{
    public class AurionproDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
