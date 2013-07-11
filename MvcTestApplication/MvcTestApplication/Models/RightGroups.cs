using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTestApplication.Models
{
    public class RightGroups
    {
        public int UserID { get; set; }
        public bool isAdmin { get; set; }
        public bool isUser { get; set; }
        public bool isEditor { get; set; }
    }
}