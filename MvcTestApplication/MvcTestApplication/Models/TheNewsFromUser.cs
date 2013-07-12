using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTestApplication.Models
{
    public class TheNewsFromUser
    {
        public int NewsID;
        public string[] News;
        public Rubric BelongRubric; // 1-1
    }
}