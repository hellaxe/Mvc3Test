using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTestApplication.Models
{
    public class TheNew
    {
        public int ID { get; set; }
        public DateTime CreateTime { get; set; }
        public string[] Text { get; set; }
        public string[] Tag { get; set; }
        public string Rubric { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}