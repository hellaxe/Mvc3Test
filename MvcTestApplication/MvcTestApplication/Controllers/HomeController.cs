using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTestApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Новостной Портал";
            // nu ohuet' teper'
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
