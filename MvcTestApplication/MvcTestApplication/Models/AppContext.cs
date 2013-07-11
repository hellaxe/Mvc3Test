using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcTestApplication.Models;

//    public class AppContext : DbContext<br />    {<br />       
 //       public DbSet<Vacancy> Vacancies { get; set; }<br />      
 //       public DbSet<Employer> Employers { get; set; }<br />    }<br />}
//Н


namespace MvcTestApplication.Models
{
    public class AppContext
    {
        public DbSet<UserID> UserID { get; set; }
        public DbSet<RightGroups> RightGroups { get; set; }
    }
}