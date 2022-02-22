using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

using WebWithAuth.Models;

namespace WebWithAuth.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Login(HUser user)
        {
            using (var context = new testEntities())
            {
                bool isValid = context.User.Any(x => x.UName == user.UName && x.Password == user.Password);

                if(isValid)
                {
                    
                    FormsAuthentication.SetAuthCookie(user.UName, false);
                    return RedirectToAction("Index","Etudiants");
                }
                ModelState.AddModelError("", "Invalid username and password");
                
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}