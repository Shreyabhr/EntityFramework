using Customers.Model;
using Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerDbMVCApp.Controllers
{
    public class DisplayController : Controller
    {
        private ICustomerServices _services;

        public DisplayController(ICustomerServices services)
        {
            _services = services;
        }
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {

            List<Customer> students = _services.GetCustomers();
            ViewBag.Count = students.Count();
            return View(students);
        }

        
        [HttpGet]
        [Authorize]
        public ActionResult Delete(int id)
        {
            _services.DeleteCustomer(id);
            return RedirectToAction("Index", "Display");
        }
        
        
    }
}