using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Furst_Alpha_2._0.Models;
using System.IO;

namespace Furst_Alpha_2._0.Controllers
{
    public class VendorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Vendors
        public ActionResult Index()
        {
            return View(db.Vendors.ToList());
        }

        // GET: Vendors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vendors vendors = db.Vendors.Find(id);
            if (vendors == null)
            {
                return HttpNotFound();
            }
            return View(vendors);
        }

        // GET: Vendors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VendorId,VendorName,NextBarcode")] Vendors vendors)
        {
            if (ModelState.IsValid)
            {
                db.Vendors.Add(vendors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vendors);
        }

        // GET: Vendors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vendors vendors = db.Vendors.Find(id);
            if (vendors == null)
            {
                return HttpNotFound();
            }
            return View(vendors);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VendorId,VendorName,NextBarcode")] Vendors vendors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vendors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vendors);
        }

        // GET: Vendors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vendors vendors = db.Vendors.Find(id);
            if (vendors == null)
            {
                return HttpNotFound();
            }
            return View(vendors);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vendors vendors = db.Vendors.Find(id);
            db.Vendors.Remove(vendors);
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


        // GET: Vendors/AssetUpload/6
        public ActionResult AssetUpload()
        {
            return View();
        }

        // POST: Vendors/AssetUpload/7
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssetUpload(HttpPostedFileBase File)
        {
            ViewBag.Message = "File is null or empty!";
            // Verify that the user selected a file
            if (File != null && File.ContentLength > 0)
            {
                ViewBag.Message = "There was an error reading your file, please check the format and spelling of data!";
                StreamReader csvReader = new StreamReader(File.InputStream);
                {
                    string inputLine = "";
                    ApplicationDbContext context = new ApplicationDbContext();
                    var input = "";
                    try
                    {
                        while ((inputLine = csvReader.ReadLine()) != null)
                        {
                            string[] values = inputLine.Split(new Char[] { ',' });
                            Assets asset = new Assets();
                            input = values[0];
                            asset.Vendor = context.Vendors.Single(s => s.VendorName == input);
                            input = values[1];
                            asset.Category = context.Categories.Single(s => s.CategoryName == input);
                            input = values[2];
                            asset.Type = context.Types.Single(s => s.TypeName == input);
                            input = values[3];
                            asset.Make = context.Makes.Single(s => s.MakeName == input);
                            input = values[4];
                            asset.Model = context.Models.Single(s => s.ModelName == input);

                            var part1 = (asset.Vendor.VendorId + 1000).ToString();
                            var part4 = (10000000 + asset.AssetId).ToString();

                            asset.Barcode = part1.Substring(1) + part4.Substring(1);
                            asset.Image = values[5];
                            asset.YearPurchased = Convert.ToInt16(values[6]);
                            asset.RentalPrice = Convert.ToDouble(values[7]);
                            asset.NumTechsReq = Convert.ToInt16(values[8]);
                            asset.Availability = Convert.ToBoolean(values[9]);
                            db.Assets.Add(asset);
                            db.SaveChanges();
                            ViewBag.Message = "File uploaded successfully";
                        }
                        csvReader.Close();
                    }
                    catch(Exception ex)
                    {
                        return AssetUpload();
                    }
                }
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Index");
        }

    }
}
