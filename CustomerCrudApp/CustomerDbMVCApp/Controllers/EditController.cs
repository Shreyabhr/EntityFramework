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
    public class EditController : Controller
    {
        private ICustomerServices _services;

        public EditController(ICustomerServices services)
        {
            _services = services;
        }
        // GET: Edit       
        [HttpGet]
        [Authorize]
        public ActionResult Index(int id)
        {
            Customer s = _services.GetCustomer(id);

            EditViewModel vm = new EditViewModel();
            vm.Name = s.Name;
            vm.Location = s.Location;
            vm.Balance = s.Balance;
            vm.Type = s.Type3;
            return View(vm);
        }

        [HttpPost]
        
        public ActionResult Index(EditViewModel vm, int id)
        {
            ViewBag.id = id;
            Customer c = new Customer { Id = id, Name = vm.Name, Location = vm.Location, Balance = vm.Balance, Type3 = vm.Type };
            _services.UpdateCustomer(c);
            return RedirectToAction("Index", "Display");
        }
    }
}