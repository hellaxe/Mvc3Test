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
        public DbSet<User> User { get; set; }
        public DbSet<TheNew> TheNew { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}