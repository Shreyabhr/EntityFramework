using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingInEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionproDBContext db = new AurionproDBContext();
            Dept d = new Dept { Id = 11, DeptName = "IT", Location = "Kolkata" };
            Emp e = new Emp { Id = 101, EName = "Prachi", Job = "Clerk", Salary = 45000, Department = d };

            db.Depts.Add(d);            
            db.Emps.Add(e);
            db.SaveChanges();
        }
    }
}
