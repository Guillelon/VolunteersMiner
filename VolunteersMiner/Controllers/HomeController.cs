using DAL.Model;
using DAL.Repositories;
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
        private PollRepository _repo;

        public HomeController()
        {
            _repo = new PollRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Poll()
        {
            return View();
        }

        [Authorize]
        public ActionResult List()
        {
            var list = _repo.GetAll();
            return View(list);
        }

        public ActionResult SuccessMessage()
        {
            //ViewBag.Info = TempData["Info"].ToString();
            return View("SuccessMessage");
        }
    }
}