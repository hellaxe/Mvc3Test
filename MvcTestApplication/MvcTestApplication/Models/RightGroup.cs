using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTestApplication.Models
{
    public class RightGroup
    {
        //public int UserID { get; set; }
        public DateTime Time { get; set; }
        public bool isAdmin { get; set; }
        public bool isUser { get; set; }
        public bool isEditor { get; set; }
    }
}