using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FrankenApp.Models;

namespace FrankenApp.Controllers
{
    public class ProbaController : Controller
    {
        private FrankenAppContext db = new FrankenAppContext();

        // GET: Proba
        public ActionResult Index()
        {
            return View(db.Probe.ToList());
        }

        // GET: Proba/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proba proba = db.Probe.Find(id);
            if (proba == null)
            {
                return HttpNotFound();
            }
            return View(proba);
        }

        // GET: Proba/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proba/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Prob")] Proba proba)
        {
            if (ModelState.IsValid)
            {
                db.Probe.Add(proba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proba);
        }

        // GET: Proba/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proba proba = db.Probe.Find(id);
            if (proba == null)
            {
                return HttpNotFound();
            }
            return View(proba);
        }

        // POST: Proba/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Prob")] Proba proba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proba);
        }

        // GET: Proba/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proba proba = db.Probe.Find(id);
            if (proba == null)
            {
                return HttpNotFound();
            }
            return View(proba);
        }

        // POST: Proba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proba proba = db.Probe.Find(id);
            db.Probe.Remove(proba);
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
