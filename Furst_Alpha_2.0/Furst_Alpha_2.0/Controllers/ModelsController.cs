﻿using System;
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
    public class ModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Models
        public ActionResult Index()
        {
            return View(db.Models.ToList());
        }

        // GET: Models/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Furst_Alpha_2._0.Models.Models models = db.Models.Find(id);
            if (models == null)
            {
                return HttpNotFound();
            }
            return View(models);
        }

        // GET: Models/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Models/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ModelId,ModelName")] Furst_Alpha_2._0.Models.Models models)
        {
            if (ModelState.IsValid)
            {
                db.Models.Add(models);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(models);
        }

        // GET: Models/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Furst_Alpha_2._0.Models.Models models = db.Models.Find(id);
            if (models == null)
            {
                return HttpNotFound();
            }
            return View(models);
        }

        // POST: Models/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ModelId,ModelName")] Furst_Alpha_2._0.Models.Models models)
        {
            if (ModelState.IsValid)
            {
                db.Entry(models).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(models);
        }

        // GET: Models/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Furst_Alpha_2._0.Models.Models models = db.Models.Find(id);
            if (models == null)
            {
                return HttpNotFound();
            }
            return View(models);
        }

        // POST: Models/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Furst_Alpha_2._0.Models.Models models = db.Models.Find(id);
            db.Models.Remove(models);
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
