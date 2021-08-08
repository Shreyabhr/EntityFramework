using CustomerDbMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CustomerDbMVCApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel vm, string ReturnUrl)
        {
            var name = vm.Name;
            var pass = vm.Password;
            if(vm.Name == "admin" && vm.Password == "admin")
            {
                FormsAuthentication.SetAuthCookie(vm.Name, false);
                Session["username"] = vm.Name;
                if(ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
            }
            return RedirectToAction("Index", "Display");
        }

    }
}