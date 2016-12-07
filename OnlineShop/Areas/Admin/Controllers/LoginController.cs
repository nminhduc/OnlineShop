using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Areas.Admin.Models;
using Models;
using OnlineShop.Areas.Admin.code;
using System.Web.Security;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
          //  var result = new AccountModel().Login(model.UserName, model.Password);
            if(Membership.ValidateUser(model.UserName, model.Password) && ModelState.IsValid)
            {
                // SessionHelper.SetSession(new UserSession() {UserName = model.UserName });
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToAction("index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "UserName or Password is Invalid");
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}