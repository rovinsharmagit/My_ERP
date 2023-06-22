using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyERP.Controllers
{
    public class HomeController : Controller
    {
         readonly db_class.EaseErpV1Entities _db = new db_class.EaseErpV1Entities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUSer(string email, string password)
        {
            var user = _db.tblUsers.Where(u => u.Email== email && u.Password == password).FirstOrDefault();
            if (user != null) 
            {
                Session["UserTypeID"] = user.UserTypeID;
                Session["FullName"] = user.FullName;
                Session["Email"] = user.Email;
                Session["ContactNo"] = user.ContactNo;
                Session["UserName"] = user.UserName;
                Session["Password"] = user.Password;
                Session["IsActive"] = user.IsActive;  
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Invalid Credentials!";

                Session["UserTypeID"] = string.Empty;
                Session["FullName"] = string.Empty;
                Session["Email"] = string.Empty;
                Session["ContactNo"] = string.Empty;
                Session["UserName"] = string.Empty;
                Session["Password"] = string.Empty;
                Session["IsActive"] = string.Empty;
            }

            return View("Login");
        }

        public ActionResult ForgetPassword() 
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}