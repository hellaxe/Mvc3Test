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
        public DateTime CreateAccountTime { get; set; }
        public virtual ICollection<TheNewsFromUser> News { get; set; } //для отношения один юзер-много новостей
        public RightGroup Group { get; set; } // 1-1
    }
}