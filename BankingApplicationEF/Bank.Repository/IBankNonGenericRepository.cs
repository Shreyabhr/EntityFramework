using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository
{
    public interface IBankNonGenericRepository 
    {
        IQueryable<Account> Login(string name, string password);
        bool DoTransaction(string name, string password, string date,double amount, string type);
        List<Transaction> GetTransactions(string name, string password);
        //string Registration(Account account);
        List<Transaction> GetAllTransactions(Guid id);

        string RegisterUser(Account account);
    }
}
