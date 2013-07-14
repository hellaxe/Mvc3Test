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
    public class CommentController : Controller
    {
        private AppContext db = new AppContext();

        //
        // GET: /Comment/

        public ViewResult Index()
        {
            return View(db.Comment.ToList());
        }

        //
        // GET: /Comment/Details/5

        public ViewResult Details(int id)
        {
            Comment comment = db.Comment.Find(id);
            return View(comment);
        }

        //
        // GET: /Comment/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Comment/Create

        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Comment.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(comment);
        }
        
        //
        // GET: /Comment/Edit/5
 
        public ActionResult Edit(int id)
        {
            Comment comment = db.Comment.Find(id);
            return View(comment);
        }

        //
        // POST: /Comment/Edit/5

        [HttpPost]
        public ActionResult Edit(Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comment);
        }

        //
        // GET: /Comment/Delete/5
 
        public ActionResult Delete(int id)
        {
            Comment comment = db.Comment.Find(id);
            return View(comment);
        }

        //
        // POST: /Comment/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Comment comment = db.Comment.Find(id);
            db.Comment.Remove(comment);
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