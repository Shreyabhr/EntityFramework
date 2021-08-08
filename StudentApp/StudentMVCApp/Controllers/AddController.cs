using Students.Model;
using Students.Services;
using StudentMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentMVCApp.Controllers
{
    public class AddController : Controller
    {
        private IStudentService _service;

        public AddController(IStudentService service)
        {
            _service = service;
        }
        // GET: Add
        [HttpGet]
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
            Student s = new Student(vm.Name, vm.RollNo, vm.Cgpa);
            _service.AddStudent(s);
            return RedirectToAction("Index", "Display");            
        }
    }
}