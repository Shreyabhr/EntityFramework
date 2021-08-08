using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bank.Model
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        [Range(500,double.MaxValue)]
        public double Balance { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
    }
}
