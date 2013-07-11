using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTestApplication.Models
{
    public class UserID
    {
        public int ID { get; set; }
        public int OldPassword { get; set; }
        public int NewPassword { get; set; }
        public int Email { get; set; }
    }
}