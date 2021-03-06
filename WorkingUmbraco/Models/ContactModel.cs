﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingUmbraco.Models
{
    public class ContactModel
    {
        //id
        public int Id { get; set; }

        //email
        public string Email { get; set; }

        //Name
        public string Name { get; set; }

        //Message
        public string Message { get; set; }

        //list of items
        public List<SelectListItem> ListOfTitles { get; set; }

        //selected title
        public string SelectedTitle { get; set; }
    }
}