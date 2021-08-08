using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankWebApiApp.Models
{
    public class AccountDTO
    {
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Range(500, double.MaxValue)]
        public double Balance { get; set; }
        
    }
}