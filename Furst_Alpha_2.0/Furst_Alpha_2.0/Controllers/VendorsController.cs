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
using System.Text.RegularExpressions;
using System.Data.Entity.Migrations;

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

                    Regex r = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
                    try
                    {
                        if ((inputLine = csvReader.ReadLine()) != null)
                        {
                            while ((inputLine = csvReader.ReadLine()) != null)
                            {
                                string[] values = r.Split(inputLine);
                                var temp1 = values[0];
                                var temp2 = values[1];
                                var temp3 = values[2];
                                var temp4 = values[3];
                                var temp5 = values[4];
                                var temp6 = values[5];
                                var temp7 = values[6];
                                var temp8 = values[7];
                                var temp9 = values[8];
                                var temp10 = values[9];
                                Assets asset = new Assets {
                                    AssetId = Convert.ToInt32(temp1),
                                    VendorId = context.Vendors.First(s => s.VendorName == temp2).VendorId,
                                    CategoryId = context.Categories.First(s => s.CategoryName == temp3).CategoryId,
                                    TypeId = context.Types.First(s => s.TypeName == temp4).TypeId,
                                    MakeId = context.Makes.First(s => s.MakeName == temp5).MakeId,
                                    ModelId = context.Models.First(s => s.ModelName == temp6).ModelId,
                                    //Barcode = context.Vendors.First(s => s.VendorName == temp2).NextBarcode.ToString(),
                                    Barcode = temp1,
                                    YearPurchased = Convert.ToInt16(temp7),
                                    RentalPrice = Convert.ToDouble(temp8),
                                    NumTechsReq = Convert.ToInt16(temp9),
                                    Availability = Convert.ToBoolean(temp10)
                                };
                                context.Assets.AddOrUpdate(p => p.Barcode, asset);
                                context.SaveChanges();
                                ViewBag.Message = "Partial Input loaded, please contact the developers.";
                            }
                            csvReader.Close();
                            ViewBag.Message = "File uploaded successfully";
                        }
                    }
                    catch (Exception ex)
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
