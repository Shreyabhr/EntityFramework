using System;
using System.ComponentModel.DataAnnotations;

namespace StudentMVCApp.Models
{
    public class EditViewModel
    {
        public Guid Guid { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter RollNo")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Please Enter Cgpa")]
        public double Cgpa { get; set; }
    }
}