using Students.Model;
using Students.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudentMVCApp.Controllers
{
    public class DisplayController : Controller
    {
        private IStudentService _services;

        public DisplayController(IStudentService services)
        {
            _services = services;
        }
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            
            List<Student> students = _services.GetStudents();
            ViewBag.Count = _services.Count();
            return View(students);
        }
    }
}