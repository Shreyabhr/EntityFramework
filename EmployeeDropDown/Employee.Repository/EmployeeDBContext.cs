using Employees.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Repository
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<EMP> Employees { get; set; }
        public DbSet<DEPT> department { get; set; }
    }
}
