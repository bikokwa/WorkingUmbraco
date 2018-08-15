using System;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using WorkingUmbraco.Models;

namespace WorkingUmbraco.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        public ActionResult ShowForm()
        {
            //an instance of the model class
            ContactModel myModel = new ContactModel();
           
            return PartialView("ContactForm", myModel);
        }

        public ActionResult HandleFormPost(ContactModel model)
        {
            var newComment = Services.ContentService.CreateContent(model.Name + " - " + DateTime.Now.ToString(), CurrentPage.Id, "ContactFormula");
            
            newComment.SetValue("emailFrom", model.Email);
            newComment.SetValue("contactName", model.Name);
            newComment.SetValue("contactMessage", model.Message);
            Services.ContentService.SaveAndPublishWithStatus(newComment);
            return RedirectToCurrentUmbracoPage();
        }
    }
}