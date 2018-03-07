using AWDC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;

namespace AWDC.Controllers
{
    public class ContactFormSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        // GET: ContactFormSurface

        public ActionResult Index()
        {
            return PartialView("_ContactForm", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {
            if (!ModelState.IsValid)
            {
               
                return CurrentUmbracoPage();          
            }
            MailMessage message = new MailMessage();
            message.To.Add("lisablaga@gmail.com");
            message.Subject = model.Subject;
            message.From = new MailAddress(model.Email, model.Name);
            message.Body = model.Message;

            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("email", "password");
                smtp.EnableSsl = true;
                // send mail
                smtp.Send(message);
                TempData["success"] = true;
            }
            
           

            IContent comment = Services.ContentService.CreateContent(model.Subject, CurrentPage.Id, "Message");
            comment.SetValue("messageName", model.Name);
            comment.SetValue("email", model.Email);
            comment.SetValue("subject", model.Subject);
            comment.SetValue("messageContent", model.Message);

            Services.ContentService.Save(comment);
            Services.ContentService.SaveAndPublishWithStatus(comment);
            return RedirectToCurrentUmbracoPage();
        }
       

    }
}