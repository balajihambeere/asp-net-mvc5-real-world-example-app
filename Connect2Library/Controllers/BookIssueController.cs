using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Connect2Library.Models;

namespace Connect2Library.Controllers
{
    public class BookIssueController : Controller
    {
        private Connect2LibraryContext db = new Connect2LibraryContext();

        // GET: BookIssue
        public ActionResult Index()
        {
            return View(db.BookIssues.ToList());
        }

        // GET: BookIssue/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookIssue bookIssue = db.BookIssues.Find(id);
            if (bookIssue == null)
            {
                return HttpNotFound();
            }
            return View(bookIssue);
        }

        // GET: BookIssue/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookIssue/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookIssueID,BookCode,DateIssued,DateReturn,DateReturned,BookIssuedStatus,FineRange,CreatedBy,CreatedOn,LastModifiedBy,LastModifiedOn")] BookIssue bookIssue)
        {
            if (ModelState.IsValid)
            {
                db.BookIssues.Add(bookIssue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookIssue);
        }

        // GET: BookIssue/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookIssue bookIssue = db.BookIssues.Find(id);
            if (bookIssue == null)
            {
                return HttpNotFound();
            }
            return View(bookIssue);
        }

        // POST: BookIssue/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookIssueID,BookCode,DateIssued,DateReturn,DateReturned,BookIssuedStatus,FineRange,CreatedBy,CreatedOn,LastModifiedBy,LastModifiedOn")] BookIssue bookIssue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookIssue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookIssue);
        }

        // GET: BookIssue/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookIssue bookIssue = db.BookIssues.Find(id);
            if (bookIssue == null)
            {
                return HttpNotFound();
            }
            return View(bookIssue);
        }

        // POST: BookIssue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookIssue bookIssue = db.BookIssues.Find(id);
            db.BookIssues.Remove(bookIssue);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
