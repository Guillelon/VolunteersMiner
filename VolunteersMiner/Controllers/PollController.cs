using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteersMiner.Controllers
{
    public class PollController : Controller
    {
        private PollRepository _repo;
        public PollController()
        {
            _repo = new PollRepository();
        }

        public ActionResult Index()
        {
            var all = _repo.GetAll();
            return View(all);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[CaptchaValidator]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Poll model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                _repo.Add(model);
            }
            return null;
        }
    }
}