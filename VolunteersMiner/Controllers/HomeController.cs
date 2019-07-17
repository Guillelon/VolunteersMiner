﻿using DAL.Model;
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

        [HttpPost]
        //[CaptchaValidator]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Poll(Poll model)
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