using Students.Model;
using Students.Services;
using StudentMVCApp.Models;
using System;
using System.Web.Mvc;

namespace StudentMVCApp.Controllers
{
    public class EditController : Controller
    {
        private IStudentService _services;

        public EditController(IStudentService services)
        {
            _services = services;
        }
        // GET: Edit
        [HttpGet]
        public ActionResult Index(Guid id)
        {
            Student s = _services.GetStudent(id);

            EditViewModel vm = new EditViewModel();
            vm.Guid = id;
            vm.Name = s.Name;
            vm.RollNo = s.RollNo;
            vm.Cgpa = s.Cgpa;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(EditViewModel vm, Guid id)
        {
            ViewBag.id = id;
            _services.UpdateStudent(id, vm.Name, vm.RollNo, vm.Cgpa);
            return RedirectToAction("Index","Display");
        }
    }
}