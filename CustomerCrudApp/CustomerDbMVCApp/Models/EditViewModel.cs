using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerDbMVCApp.Models
{
    public class EditViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public double Balance { get; set; }
        [Required]
        public string Type { get; set; }
    }
}