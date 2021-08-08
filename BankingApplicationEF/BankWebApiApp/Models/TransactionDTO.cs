using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankWebApiApp.Models
{
    public class TransactionDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public double Amount { get; set; }
        public string Date { get; set; }
        [Required]
        public string TransactionType { get; set; }
        //public  AccountDTO Account { get; set; }
    }
}