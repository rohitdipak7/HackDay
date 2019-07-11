using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackDay.Models

namespace HackDay.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if(model.UserName == "user" && model.Password == "user" )
            {
                return RedirectToAction();
            }
            else if(model.UserName == "admin" && model.Password == "admin")
            {
                return RedirectToAction();
            }
            return View();
        }
    }
}