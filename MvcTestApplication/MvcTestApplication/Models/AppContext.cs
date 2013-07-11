using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcTestApplication.Models;


namespace MvcTestApplication.Models
{
    public class AppContext
    {
        public DbSet<UserID> UserID { get; set; }
        public DbSet<RightGroups> RightGroups { get; set; }
    }
}