using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEF
{
    public class Employee
    {
        [Key]
        public int ENo { get; set; }
        public string EName { get; set; }
        public virtual Department department { get; set; }
    }
}
