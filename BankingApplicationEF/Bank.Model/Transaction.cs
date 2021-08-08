using System;
using System.ComponentModel.DataAnnotations;

namespace Bank.Model
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
        public string Date { get; set; }
        public virtual Account Account { get; set; }
    }
}
