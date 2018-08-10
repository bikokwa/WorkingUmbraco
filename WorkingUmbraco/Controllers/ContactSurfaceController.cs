using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using WorkingUmbraco.Models;

namespace WorkingUmbraco.Controllers
{
    public class ContactSurfaceController: SurfaceController 
    {
        public ActionResult ShowForm()
        {
            return PartialView("ContactForm", new ContactModel());
        }
    }
}