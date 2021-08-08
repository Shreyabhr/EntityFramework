using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerDbMVCApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}