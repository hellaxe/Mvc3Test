using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTestApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string RightGroup { get; set; }
        public string Hash { get; set; }
        public virtual ICollection<TheNew> TheNew { get; set; } //для отношения один юзер-много новостей
    }
}