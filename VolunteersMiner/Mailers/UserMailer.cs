using DAL.Model;
using Mvc.Mailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace VolunteersMiner.Mailers
{
    public class UserMailer : MailerBase
    {
        public UserMailer()
        {
            MasterName = "_Layout";
        }

        public virtual void Thanks(Poll poll)
        {
            ViewBag.Data = poll;
            
            var mail = Populate(x =>
            {
                x.Subject = poll.Name() + ", gracias por tu interés en ayudar.";
                x.ViewName = "Thanks";
                x.To.Add(poll.Email);
            });
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("info@zip-cargo.com", "123Zipcargo+");
            client.Send(mail);
        }
    }
}