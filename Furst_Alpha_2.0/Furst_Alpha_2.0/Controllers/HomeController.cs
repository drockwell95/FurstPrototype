using Furst_Alpha_2._0.HelperClasses;
using Furst_Alpha_2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Furst_Alpha_2._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //
        // GET: /Home/StoreLocator
        public ActionResult StoreLocator()
        {
            return View();
        }

        //
        // POST: /Home/StoreLocator
        [HttpPost]
        public ActionResult StoreLocator(string address)
        {
            // Make sure we have an address
            if (string.IsNullOrEmpty(address))
                return View();

            var results = GoogleMapsAPIHelpersCS.GetGeocodingSearchResults(address);

            var resultCount = results.Elements("result").Count();

            if (resultCount == 0)
            {
                // No matching address found!
                ViewData["NoResults"] = true;
                return View();
            }
            else if (resultCount == 1)
            {
                // Got back exactly one result, show it!
                return RedirectToAction("StoreLocatorResults", new { Address = results.Element("result").Element("formatted_address").Value });
            }
            else
            {
                // Got back multiple results - We need to ask the user which address they mean to use...
                var matches = from result in results.Elements("result")
                              let formatted_address = result.Element("formatted_address").Value
                              select formatted_address;

                

                ViewData["Matches"] = matches;
                return View();
            }
        }

        //
        // GET: /Home/StoreLocatorResults
        public ActionResult StoreLocatorResults(string address)
        {
            var context = new ApplicationDbContext();

            if (address == null)
            {
                ViewData["ResultsCount"] = context.VendorWarehouses.Count();
                return View(context.VendorWarehouses.ToList());
            }

            // Get the lat/long info about the address
            var results = GoogleMapsAPIHelpersCS.GetGeocodingSearchResults(address);

            // Determine the lat & long parameters
            var lat = Convert.ToDecimal(results.Element("result").Element("geometry").Element("location").Element("lat").Value);
            var lng = Convert.ToDecimal(results.Element("result").Element("geometry").Element("location").Element("lng").Value);


            // Get those locations near the store


            var nearbyStores = from warehouse in context.VendorWarehouses
                               where Math.Abs(warehouse.Latitude - lat) < 0.25M &&
                                     Math.Abs(warehouse.Longitude - lng) < 0.25M
                               select warehouse;


            ViewData["ResultsCount"] = context.VendorWarehouses.Count();
            return View(context.VendorWarehouses.ToList());

            //var nearbyWarehouses = nearbyStores.Where(x => x.VendorWarehouseId > 0).ToList()
            //                    .Select(x => new NearbyVendorWarehouseLocation
            //                    {
            //                        VendorWarehouseId = x.VendorWarehouseId,
            //                        Address = x.Address,
            //                        City = x.City,
            //                        Region = x.Region,
            //                        CountryCode = x.CountryCode,
            //                        PostalCode = x.PostalCode,
            //                        Latitude = x.Latitude,
            //                        Longitude = x.Longitude,
            //                        AddressLatitude = lat,
            //                        AddressLongitude = lng
            //                    }).ToList(); 
            

            //var nearbySortedVendorWarehouses = nearbyWarehouses.ToList().OrderBy(s => s.DistanceFromAddress).ToList();

            
            //if (nearbySortedVendorWarehouses.Count == 0)
            //{
            //    return View(nearbyStores);
            //}
            //else
            //{
            //    //return View(nearbyStores);
            //    return View(nearbySortedVendorWarehouses);
            //}
        }
    }
}