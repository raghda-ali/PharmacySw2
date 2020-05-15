using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(Pharmacist objUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (MyDBContext db = new MyDBContext())
        //        {
        //            var obj = db.pharmacists.Where(a => a.Username.Equals(objUser.Username) && a.Password.Equals(objUser.Password)).FirstOrDefault();
        //            if (obj != null)
        //            {
        //                Session["id"] = obj.id.ToString();
        //                Session["Username"] = obj.Username.ToString();
        //                return RedirectToAction("UserDashBoard");
        //            }
        //        }
        //    }
        //    return View(objUser);
        //}

        //public ActionResult UserDashBoard()
        //{
        //    if (Session["idservese"] != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login");
        //    }
        }
    }
