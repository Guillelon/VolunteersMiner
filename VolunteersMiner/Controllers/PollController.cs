using DAL.Model;
using DAL.Repositories;
using reCAPTCHA.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolunteersMiner.Mailers;

namespace VolunteersMiner.Controllers
{
    public class PollController : Controller
    {
        private PollRepository _repo;
        private UserMailer _mailer;
        public PollController()
        {
            _repo = new PollRepository();
            _mailer = new UserMailer();
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
                var emailHelper = new EmailAddressAttribute();
                if (emailHelper.IsValid(model.Email))
                {
                    model.CreatedDate = DateTime.Now;
                    _repo.Add(model);
                    TempData["Info"] = model.Name();

                    try
                    {
                        _mailer.Thanks(model);
                    }
                    catch (Exception e){
                        var hola = 2;
                    }

                    return RedirectToAction("SuccessMessage");
                }
                else
                {
                    ViewBag.ErrorMessage = "Por favor colocar un email válido";
                    return View(model);
                }
            }

            ViewBag.ErrorMessage = "Revisar los campos requeridos";
            return View(model);
        }

        public ActionResult SuccessMessage()
        {
            return View("SuccessMessage");
        }
    }
}