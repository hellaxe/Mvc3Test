using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcTestApplication.Models;


namespace MvcTestApplication.Models
{
    public class AppContext : DbContext
    {
        public DbSet<UserID> UserIDs { get; set; }
        public DbSet<RightGroup> RightGroups { get; set; }
        public DbSet<Rubric> Rubrics { get; set; }
        public DbSet<TheNewsFromUser> News { get; set; }
    }
}