using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}