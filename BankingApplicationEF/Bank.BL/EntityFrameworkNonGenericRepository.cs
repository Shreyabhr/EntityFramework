using Bank.Model;
using Bank.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BL
{
    public class EntityFrameworkNonGenericRepository : IBankNonGenericRepository
    {
        private BankingDBContext _db;
        private IBankGenericRepository<Account> _accountRepository;
        private IBankGenericRepository<Transaction> _transactionRepository;

        public EntityFrameworkNonGenericRepository()
        {
            _db = new BankingDBContext();
            _accountRepository = new EntityFrameworkGenericRepository<Account>();
            _transactionRepository = new EntityFrameworkGenericRepository<Transaction>();
        }
        public bool DoTransaction(string name, string password, string date,double amount, string type)
        {
            var dbTransaction = _db.Database.BeginTransaction();
            try
            {
                var account = _db.Accounts.Where(a => a.Name == name && a.Password == password).First();
                if (type == "D")
                {
                    account.Balance += amount;
                }
                else
                {
                    account.Balance -= amount;
                }                            
                SaveChanges();
                var transaction = new Transaction { Id = Guid.NewGuid(), Name = name, Amount = amount, Date = date,TransactionType = type, Account = account };
                _db.Transactions.Add(transaction);
                SaveChanges();
                dbTransaction.Commit();
                return true;
            }
            catch (Exception)
            {
                dbTransaction.Rollback();
                return false;
                //Console.WriteLine(e);
            }
        }

        public List<Transaction> GetAllTransactions(Guid id)
        {
            var transactions = _db.Transactions
                               .Where(t => t.Account.Id == id);
            return transactions.ToList();
        }

        public List<Transaction> GetTransactions(string name, string password)
        {
            var account = _db.Accounts
                              .Where(t => t.Name == name && t.Password == password)                           
                              .Select(s =>new {Id = s.Id}).First();
            var transaction = _db.Transactions
                              .Where(t => t.Account.Id == account.Id)
                              .ToList();
            return transaction;
        }

        public IQueryable<Account> Login(string name, string password)
        {
            var accountHolder = _db.Accounts
                                .Where(e => e.Name == name && e.Password == password);                               
            return accountHolder;
        }

        

        public string RegisterUser(Account account)
        {
            var dbTransaction = _db.Database.BeginTransaction();
            try
            {
                
                var transaction = new Transaction { Id = Guid.NewGuid(), Name = account.Name, Amount = account.Balance, Date = DateTime.Now.ToString(), TransactionType = "D", Account = account };
                _transactionRepository.Insert(transaction);
                _db.Transactions.Add(transaction);
                account.Transactions = new List<Transaction>();
                account.Transactions.Add(transaction);
                _accountRepository.Insert(account);
                SaveChanges();
                dbTransaction.Commit();
                return account.Id.ToString();
            }
            catch (Exception)
            {
                dbTransaction.Rollback();
               
                return null;
            }


        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        
    }
}
