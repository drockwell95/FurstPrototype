using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Furst_Alpha_2._0.Models;

namespace Furst_Alpha_2._0.Controllers
{
    public class QuantitiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Quantities
        public ActionResult Index()
        {
            return View(db.Quantities.ToList());
        }

        // GET: Quantities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quantities quantities = db.Quantities.Find(id);
            if (quantities == null)
            {
                return HttpNotFound();
            }
            return View(quantities);
        }

        // GET: Quantities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quantities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuantityId,total,InUse")] Quantities quantities)
        {
            if (ModelState.IsValid)
            {
                db.Quantities.Add(quantities);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quantities);
        }

        // GET: Quantities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quantities quantities = db.Quantities.Find(id);
            if (quantities == null)
            {
                return HttpNotFound();
            }
            return View(quantities);
        }

        // POST: Quantities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuantityId,total,InUse")] Quantities quantities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quantities).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quantities);
        }

        // GET: Quantities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quantities quantities = db.Quantities.Find(id);
            if (quantities == null)
            {
                return HttpNotFound();
            }
            return View(quantities);
        }

        // POST: Quantities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quantities quantities = db.Quantities.Find(id);
            db.Quantities.Remove(quantities);
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
