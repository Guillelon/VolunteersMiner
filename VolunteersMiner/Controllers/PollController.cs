using DAL.DTOs;
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

        [Authorize]
        public ActionResult Index()
        {
            var all = _repo.GetAll();
            return View(all);
        }

        public ActionResult Create()
        {
            var dto = new PollDTO();
            foreach(var helpType in Helpers.GetVolunteerType())
                dto.MultipleChoiceHelps.Add(new MultipleChoiceDto { Name = helpType, Selected = false });

            foreach (var time in Helpers.GetTimes())
                dto.MultipleChoiceParticipation.Add(new MultipleChoiceDto { Name = time, Selected = false });

            return View(dto);
        }

        [HttpPost]
        [CaptchaValidator]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PollDTO dto)
        {
            if (ModelState.IsValid)
            {
                var emailHelper = new EmailAddressAttribute();
                if (emailHelper.IsValid(dto.NewPoll.Email))
                {
                    dto.NewPoll.CreatedDate = DateTime.Now;
                    dto.NewPoll.TimeToParticipate = string.Join(", ", dto.SelectedParticipation);
                    dto.NewPoll.TypeOfHelp = string.Join(", ", dto.SelectedHelps);
                    _repo.Add(dto.NewPoll);
                    TempData["Info"] = dto.NewPoll.Name();

                    try
                    {
                        _mailer.Thanks(dto.NewPoll);
                    }
                    catch (Exception e){
                        var hola = 2;
                    }

                    return RedirectToAction("SuccessMessage");
                }
                else
                {
                    foreach (var helpType in Helpers.GetVolunteerType())
                        dto.MultipleChoiceHelps.Add(new MultipleChoiceDto { Name = helpType, Selected = false });

                    foreach (var time in Helpers.GetTimes())
                        dto.MultipleChoiceParticipation.Add(new MultipleChoiceDto { Name = time, Selected = false });
                    ViewBag.ErrorMessage = "Por favor colocar un email válido";
                    return View(dto);
                }
            }
            foreach (var helpType in Helpers.GetVolunteerType())
                dto.MultipleChoiceHelps.Add(new MultipleChoiceDto { Name = helpType, Selected = false });

            foreach (var time in Helpers.GetTimes())
                dto.MultipleChoiceParticipation.Add(new MultipleChoiceDto { Name = time, Selected = false });
            ViewBag.ErrorMessage = "Revisar los campos requeridos";
            return View(dto);
        }

        public ActionResult SuccessMessage()
        {
            return View("SuccessMessage");
        }
    }
}