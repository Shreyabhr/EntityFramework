using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingInEntityFramework
{
    public class Dept
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public ICollection<Emp> Employees { get; set; }
    }
}
