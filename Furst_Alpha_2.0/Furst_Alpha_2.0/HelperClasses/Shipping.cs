using System;
using System.Collections;
using Shippo;
using Furst_Alpha_2._0.Models;
using Microsoft.AspNet.Identity;
using System.Linq;

namespace Furst_Alpha_2._0.HelperClasses
{
    public class Shipping
    {
        static readonly string TRACKING_NO = "9205590164917312751089";

        //public static void RunTrackingExample(APIResource resource)
        //{
        //    Track track = resource.RetrieveTracking("usps", TRACKING_NO);
        //    Console.WriteLine("Carrier = " + track.Carrier.ToUpper());
        //    Console.WriteLine("Tracking number = " + track.TrackingNumber);
        //}

        public void ShippingHelper(string[] args, string currentUserId)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            //var user = await UserManager.FindByNameAsync(model.Email);
            ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);

            // replace with your Shippo Token
            // don't have one? get more info here
            // (https://goshippo.com/docs/#overview)
            APIResource resource = new APIResource("shippo_test_65fd920a903fa5c329bb6c4a78458f2c86ea839a");

            // to address
            Hashtable toAddressTable = new Hashtable();
            toAddressTable.Add("object_purpose", "RENTAL");
            toAddressTable.Add("name", currentUser.Name);
            toAddressTable.Add("company", "Shippo");
            toAddressTable.Add("street1", "215 Clayton St.");
            toAddressTable.Add("city", "San Francisco");
            toAddressTable.Add("state", "CA");
            toAddressTable.Add("zip", "94117");
            toAddressTable.Add("country", "US");
            toAddressTable.Add("phone", "+1 555 341 9393");
            toAddressTable.Add("email", "support@goshipppo.com");

            // from address
            Hashtable fromAddressTable = new Hashtable();
            fromAddressTable.Add("object_purpose", "RENTAL");
            fromAddressTable.Add("name", "Ms Hippo");
            fromAddressTable.Add("company", "San Diego Zoo");
            fromAddressTable.Add("street1", "2920 Zoo Drive");
            fromAddressTable.Add("city", "San Diego");
            fromAddressTable.Add("state", "CA");
            fromAddressTable.Add("zip", "92101");
            fromAddressTable.Add("country", "US");
            fromAddressTable.Add("email", "hippo@goshipppo.com");
            fromAddressTable.Add("phone", "+1 619 231 1515");
            fromAddressTable.Add("metadata", "Customer ID 123456");

            // parcel
            Hashtable parcelTable = new Hashtable();
            parcelTable.Add("length", "5");
            parcelTable.Add("width", "5");
            parcelTable.Add("height", "5");
            parcelTable.Add("distance_unit", "in");
            parcelTable.Add("weight", "2");
            parcelTable.Add("mass_unit", "lb");

            // shipment
            Hashtable shipmentTable = new Hashtable();
            shipmentTable.Add("address_to", toAddressTable);
            shipmentTable.Add("address_from", fromAddressTable);
            shipmentTable.Add("parcel", parcelTable);
            shipmentTable.Add("object_purpose", "PURCHASE");
            shipmentTable.Add("async", false);

            // create Shipment object
            Console.WriteLine("Creating Shipment object..");
            Shipment shipment = resource.CreateShipment(shipmentTable);

            // select desired shipping rate according to your business logic
            // we simply select the first rate in this example
            Rate rate = shipment.RatesList[0];

            Console.WriteLine("Getting shipping label..");
            Hashtable transactionParameters = new Hashtable();
            transactionParameters.Add("rate", rate.ObjectId);
            transactionParameters.Add("async", false);
            Transaction transaction = resource.CreateTransaction(transactionParameters);

            if (((String)transaction.ObjectStatus).Equals("SUCCESS", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Label url : " + transaction.LabelURL);
                Console.WriteLine("Tracking number : " + transaction.TrackingNumber);
            }
            else
            {
                Console.WriteLine("An Error has occured while generating your label. Messages : " + transaction.Messages);
            }

            Console.WriteLine("\nTrack\n");
            RunTrackingExample(resource);
        }
    }
}