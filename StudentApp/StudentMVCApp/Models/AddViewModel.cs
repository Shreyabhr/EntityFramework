using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMVCApp.Models
{
    public class AddViewModel
    {
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter RollNo")]
        public int RollNo { get; set; }
        [Required(ErrorMessage = "Please Enter Cgpa")]
        public double Cgpa { get; set; }
    }
}