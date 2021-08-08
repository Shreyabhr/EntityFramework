using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingInEntityFramework
{
    public class Emp
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public Dept Department { get; set; }
    }
}
