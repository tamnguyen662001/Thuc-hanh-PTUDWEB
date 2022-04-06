using BT4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT4.Controllers
{
    public class GuiMail_61134311Controller : Controller
    {
        // GET: GuiMail_61134311
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(MailModel model)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(model.From);
            mail.To.Add(model.To);
            mail.Subject = model.Subject;
            mail.Body = model.Body;
            mail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential(model.From, model.Password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return RedirectToAction("Index", "GuiMail_61134311/Complete");
        }
        public ActionResult Complete()
        {
            return View();
        }
    }
}