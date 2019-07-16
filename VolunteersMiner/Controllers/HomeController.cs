using DAL.Model;
using reCAPTCHA.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace VolunteersMiner.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Poll()
        {
            return View();
        }

        [HttpPost]
        [CaptchaValidator]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Poll(Poll model)
        {
            return null;
        }
    }
}