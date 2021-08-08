using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEF
{
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
