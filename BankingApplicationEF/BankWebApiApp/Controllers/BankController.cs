using Bank.BL;
using Bank.Model;
using Bank.Repository;
using BankWebApiApp.Models;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BankWebApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/v1/bank")]
    public class BankController : ApiController
    {
        private IBankGenericRepository<Account> _accountRepository = new EntityFrameworkGenericRepository<Account>();
        private IBankGenericRepository<Transaction> _transactionRespository = new EntityFrameworkGenericRepository<Transaction>();

        private IBankNonGenericRepository _repository;

        public BankController(IBankNonGenericRepository repository)
        {
            _repository = repository;
        }

        [Route("{accountId}")]
        public IHttpActionResult GetAccount(Guid accountId)
        {
            var account = _accountRepository.GetById(accountId);
            return Ok(new {account.Id , account.Name, account.Password, account.Balance});
        }    

        [Route("")]
        public IHttpActionResult Registration(AccountDTO dto)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest("Something went wrong");
            }
            Account account = new Account { Id = Guid.NewGuid(), Name = dto.Name, Balance = dto.Balance, Password = dto.Password };
            var accId = _repository.RegisterUser(account);
            if(accId != null)
            {
                return Ok(accId);
            }
            return BadRequest("Something went wrong");
        }


        [Route("{accountId}/transactions")]
        public IHttpActionResult GetTransactionsByAccountId(Guid accountId)
        {
            var tran = _repository.GetAllTransactions(accountId).Select(s => new { s.Amount,s.TransactionType, s.Date});
            if(tran != null)
            {
                return Ok(tran);
            }
            return BadRequest("No transactions");
        }

        [Route("transaction")]
        public IHttpActionResult DoTransaction(TransactionDTO dto)
        {          
            if (!this.ModelState.IsValid)
            {
                return BadRequest("Something went wrong");
            }
            if(_repository.DoTransaction(dto.Name, dto.Password, dto.Date,dto.Amount, dto.TransactionType))
            {
                return Ok("succeded");
            }
            return BadRequest("Something went wrong");
        }

        [Route("account")]
        public IHttpActionResult AccountHolderInfo(LoginDTO dto)
        {
            var accountHolder = _repository.Login(dto.Name, dto.Password).First();
            if(accountHolder != null)
            {
                return Ok(new {accountHolder.Id, accountHolder.Name, accountHolder.Password });
            }
            return BadRequest("Not found");
        }
    }
}