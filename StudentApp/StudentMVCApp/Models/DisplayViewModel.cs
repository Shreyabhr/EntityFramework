using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMVCApp.Models
{
    public class DisplayViewModel
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public double Cgpa { get; set; }

    }
}