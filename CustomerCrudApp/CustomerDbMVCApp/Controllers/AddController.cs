using CustomerDbMVCApp.Models;
using Customers.Model;
using Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerDbMVCApp.Controllers
{
    public class AddController : Controller
    {
        private ICustomerServices _service;

        public AddController(ICustomerServices service)
        {
            _service = service;
        }
        // GET: Add
        
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AddViewModel vm)
        {
            if (!this.ModelState.IsValid)
            {
                return View(vm);
            }
            Customer c = new Customer { Id = vm.Id, Name = vm.Name, Location = vm.Location, Balance = vm.Balance, Type3 = vm.Type };
            _service.AddCustomer(c);
            return RedirectToAction("Index", "Display");
        }
    }
}