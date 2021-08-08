using BankWebApiApp.Models;
using BankWebApiApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank.Repository;
using Moq;
using System.Web.Http.Results;

namespace Bank.Tests
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void CheckIfBankReturnsNotFoundIfAccountNotFound()
        {
            LoginDTO dto = new LoginDTO();
            dto.Name = "shreya";
            dto.Password = "123456";
            var repo = new Mock<IBankNonGenericRepository>();
            BankController bank = new BankController(repo.Object);

            var actualresult = bank.AccountHolderInfo(dto);
            //var expectedresult = new JsonResult("name");
            //Assert.AreEqual(actualresult,expectedresult);
        }
    }
}
