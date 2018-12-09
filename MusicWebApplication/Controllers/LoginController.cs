using MusicWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicWebApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(MusicWebApplication.Models.LoginData loginModel)
        {
            using (MusicEntities db = new MusicEntities())
            {
                var userDetails = db.Login.Where(x => x.LoginName == loginModel.UserName &&
                                                      x.PassWord == loginModel.Password).FirstOrDefault();
                if(userDetails == null)
                {
                    loginModel.LoginErrorMessage = "Wrong Username and/or Password";
                    return View("index", loginModel);
                }
                else
                {
                    Session["UserID"] = userDetails.Login_ID;
                    Session["UserName"] = userDetails.LoginName;
                    return RedirectToAction("index", "Home");

                }
            }
        }
    }
}