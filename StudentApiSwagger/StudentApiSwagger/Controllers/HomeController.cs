using Students.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace StudentApiSwagger.Controllers
{
    [RoutePrefix("api/v1/aurionpro")]
    public class HomeController : ApiController
    {
        public StudentServices _services = new StudentServices();

        [Route("Students")]
        public IHttpActionResult Get()
        {
            var students = _services.GetStudents();
            return Json(students);
        }
    }
}