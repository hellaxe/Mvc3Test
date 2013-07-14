using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTestApplication.Models;

namespace MvcTestApplication.Controllers
{ 
    public class TheNewController : Controller
    {
        private AppContext db = new AppContext();

        //
        // GET: /TheNew/

        public ViewResult Index()
        {
            return View(db.TheNew.ToList());
        }

        //
        // GET: /TheNew/Details/5

        public ViewResult Details(int id)
        {
            TheNew thenew = db.TheNew.Find(id);
            return View(thenew);
        }

        //
        // GET: /TheNew/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /TheNew/Create

        [HttpPost]
        public ActionResult Create(TheNew thenew)
        {
            if (ModelState.IsValid)
            {
                db.TheNew.Add(thenew);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(thenew);
        }
        
        //
        // GET: /TheNew/Edit/5
 
        public ActionResult Edit(int id)
        {
            TheNew thenew = db.TheNew.Find(id);
            return View(thenew);
        }

        //
        // POST: /TheNew/Edit/5

        [HttpPost]
        public ActionResult Edit(TheNew thenew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thenew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thenew);
        }

        //
        // GET: /TheNew/Delete/5
 
        public ActionResult Delete(int id)
        {
            TheNew thenew = db.TheNew.Find(id);
            return View(thenew);
        }

        //
        // POST: /TheNew/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            TheNew thenew = db.TheNew.Find(id);
            db.TheNew.Remove(thenew);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}