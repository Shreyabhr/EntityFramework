using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    public class EMP
    {
        public int EMPNO { get; set; }
        public string ENAME { get; set; }
        public string JOB { get; set; }
        public int MGR { get; set; }
        public DateTime HIREDATE { get; set; }

        public double SAL { get; set; }

        public double COMM { get; set; }
        public double DEPTNO { get; set; }
    }
}
