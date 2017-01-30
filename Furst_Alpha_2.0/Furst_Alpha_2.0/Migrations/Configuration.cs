namespace Furst_Alpha_2._0.Migrations
{
    using Furst_Alpha_2._0.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Furst_Alpha_2._0.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Furst_Alpha_2._0.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //




            var models = new List<Models>
            {
                new Models {ModelId = 01, ModelName = "W515" },
                new Models {ModelId = 02, ModelName = "G300" },
                new Models {ModelId = 03, ModelName = "Cubix 6 - CX6" },
                new Models {ModelId = 04, ModelName = "Escort 3000 - PE3000" },
                new Models {ModelId = 05, ModelName = "Ice 101" },
                new Models {ModelId = 06, ModelName = "MK2 G300" },
                new Models {ModelId = 07, ModelName = "Jem" },
                new Models {ModelId = 08, ModelName = "Cloud36" },
                new Models {ModelId = 09, ModelName = "Cloud24" },
                new Models {ModelId = 10, ModelName = "SNJ110" },
                new Models {ModelId = 11, ModelName = "DNJ110" },
                new Models {ModelId = 12, ModelName = "Single Jet" },
                new Models {ModelId = 13, ModelName = "SNG" },
                new Models {ModelId = 14, ModelName = "DNG" },
                new Models {ModelId = 15, ModelName = "Haze2D" },
                new Models {ModelId = 16, ModelName = "Base110" },
                new Models {ModelId = 17, ModelName = "G300Haze" },
                new Models {ModelId = 18, ModelName = "Radiance" },
                new Models {ModelId = 19, ModelName = "DF50" },
                new Models {ModelId = 20, ModelName = "ICC110" },
                new Models {ModelId = 21, ModelName = "3sGerb" },
                new Models {ModelId = 22, ModelName = "6LGerb" },
                new Models {ModelId = 23, ModelName = "NPC30" },
                new Models {ModelId = 24, ModelName = "NPG" },
                new Models {ModelId = 25, ModelName = "Silent Snow - SS3" },
                new Models {ModelId = 26, ModelName = "T1500 Mini - BSZ" },
                new Models {ModelId = 27, ModelName = "Pro Snow - SM250" },
                new Models {ModelId = 28, ModelName = "10 Foot Aluminum - SQ414" },
                new Models {ModelId = 29, ModelName = "Bubble King - BK110" },
                new Models {ModelId = 30, ModelName = "Foam Monster - FM110" },
                new Models {ModelId = 31, ModelName = "Mini Foam Cannon - MFC110" },
                new Models {ModelId = 32, ModelName = "Extreme Foam Machine - EFM110" }
            };
            //models.ForEach(s => context.Models.AddOrUpdate(p => p.ModelId, s));
            //context.SaveChanges();

            var makes = new List<Makes>
            {
                new Makes {MakeId = 01, MakeName = "ATL Special FX" },
                new Makes {MakeId = 02, MakeName = "Antari" },
                new Makes {MakeId = 03, MakeName = "Lemaitre" },
                new Makes {MakeId = 04, MakeName = "Chauvet" },
                new Makes {MakeId = 05, MakeName = "Peavey" },
                new Makes {MakeId = 06, MakeName = "Martin" },
                new Makes {MakeId = 07, MakeName = "Moka Lighting" },
                new Makes {MakeId = 08, MakeName = "Haze Baze" },
                new Makes {MakeId = 09, MakeName = "Reel Efx" },
                new Makes {MakeId = 10, MakeName = "Global Special Effects" },
                new Makes {MakeId = 11, MakeName = "Global Truss" }
            };
            //makes.ForEach(s => context.Makes.AddOrUpdate(p => p.MakeId, s));
            //context.SaveChanges();

            var types = new List<Types>
            {
                new Types {TypeId = 01, TypeName = "Fog" },
                new Types {TypeId = 02, TypeName = "Lighting" },
                new Types {TypeId = 03, TypeName = "Sound" },
                new Types {TypeId = 04, TypeName = "Ground Fog" },
                new Types {TypeId = 05, TypeName = "Cloudvertise" },
                new Types {TypeId = 06, TypeName = "CO2 Fog" },
                new Types {TypeId = 07, TypeName = "CO2 Cryo Gun" },
                new Types {TypeId = 08, TypeName = "Haze" },
                new Types {TypeId = 09, TypeName = "Confetti" },
                new Types {TypeId = 10, TypeName = "Paint Cannon" },
                new Types {TypeId = 11, TypeName = "Snow" },
                new Types {TypeId = 12, TypeName = "Truss" },
                new Types {TypeId = 13, TypeName = "Bubble Machine" },
                new Types {TypeId = 14, TypeName = "Foam Machine" }
            };
            //types.ForEach(s => context.Types.AddOrUpdate(p => p.TypeId, s));
            //context.SaveChanges();

            var categories = new List<Categories>
            {
                new Categories {CategoryId = 01, CategoryName = "Stage" },
                new Categories {CategoryId = 02, CategoryName = "Stage Effects" },
                new Categories {CategoryId = 03, CategoryName = "Stage Equipment" }
            };
           // categories.ForEach(s => context.Categories.AddOrUpdate(p => p.CategoryId, s));
            //context.SaveChanges();

            var vendors = new List<Vendors>
            {
                new Vendors {VendorId = 01, VendorName = "Atlanta Special FX", NextBarcode = 33 }
            };
            //vendors.ForEach(s => context.Vendors.AddOrUpdate(p => p.VendorId, s));
            //context.SaveChanges();

            var assets = new List<Assets>
            {
                new Assets{
                    AssetId = 000000001,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Fog"),
                    Make = makes.Single(s => s.MakeName == "Antari"),
                    Model = models.Single(s => s.ModelName == "W515"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 175.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000002,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Fog"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "G300"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2015,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000003,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Lighting"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Cubix 6 - CX6"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2015,
                    RentalPrice = 199.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000004,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage"),
                    Type = types.Single(s => s.TypeName == "Sound"),
                    Make = makes.Single(s => s.MakeName == "Peavey"),
                    Model = models.Single(s => s.ModelName == "Escort 3000 - PE3000"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 299.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000005,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Ground Fog"),
                    Make = makes.Single(s => s.MakeName == "Antari"),
                    Model = models.Single(s => s.ModelName == "Ice 101"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2015,
                    RentalPrice = 175.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000006,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Ground Fog"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "MK2 G300"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 399.00,
                    NumTechsReq = 1,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000007,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Ground Fog"),
                    Make = makes.Single(s => s.MakeName == "Martin"),
                    Model = models.Single(s => s.ModelName == "Jem"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2015,
                    RentalPrice = 499.00,
                    NumTechsReq = 1,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000010,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Cloudvertise"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Cloud36"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 850.00,
                    NumTechsReq = 1,
                    Availability = true
                },
                new Assets{
                    AssetId = 000000011,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Cloudvertise"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Cloud24"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 550.00,
                    NumTechsReq = 1,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000011,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "CO2 Fog"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "SNJ110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 149.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000012,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "CO2 Fog"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "DNJ110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 199.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000013,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "CO2 Fog"),
                    Make = makes.Single(s => s.MakeName == "Moka Lighting"),
                    Model = models.Single(s => s.ModelName == "Single Jet"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2015,
                    RentalPrice = 149.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000014,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "CO2 Cryo Gun"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "SNG"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 99.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000015,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "CO2 Cryo Gun"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "DNG"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 159.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000016,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Haze"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Haze2D"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 175.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000007,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Haze"),
                    Make = makes.Single(s => s.MakeName == "Haze Baze"),
                    Model = models.Single(s => s.ModelName == "Base110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 299.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000018,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Haze"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "G300Haze"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000019,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Haze"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "Radiance"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2015,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000020,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Haze"),
                    Make = makes.Single(s => s.MakeName == "Reel Efx"),
                    Model = models.Single(s => s.ModelName == "DF50"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000021,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Confetti"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "ICC110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 299.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000022,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Confetti"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "3sGerb"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 299.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000023,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Confetti"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "6LGerb"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2015,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000024,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Paint Cannon"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "NPC30"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000025,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Paint Cannon"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "NPG"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 199.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000026,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Snow"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Silent Snow - SS3"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 315.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000027,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Snow"),
                    Make = makes.Single(s => s.MakeName == "Global Special Effects"),
                    Model = models.Single(s => s.ModelName == "T1500 Mini - BSZ"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000028,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Snow"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Pro Snow - SM250"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 199.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000029,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Equipment"),
                    Type = types.Single(s => s.TypeName == "Truss"),
                    Make = makes.Single(s => s.MakeName == "Global Truss"),
                    Model = models.Single(s => s.ModelName == "10 Foot Aluminum - SQ414"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 100.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000030,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Bubble Machine"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Bubble King - BK110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 125.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000031,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Foam Machine"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Foam Monster - FM110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 499.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000032,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Foam Machine"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Mini Foam Cannon - MFC110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 399.00,
                    NumTechsReq = 0,
                    Availability = true
                },
                 new Assets{
                     AssetId = 000000033,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Category = categories.Single(s => s.CategoryName == "Stage Effects"),
                    Type = types.Single(s => s.TypeName == "Foam Machine"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Extreme Foam Machine - EFM110"),
                    Barcode = "",
                    Image = "https://www.hostedimage.com or path to storage",
                    YearPurchased = 2016,
                    RentalPrice = 350.00,
                    NumTechsReq = 0,
                    Availability = true
                }
             };


            var quantities = new List<Quantities>
            {
                 new Quantities{
                    QuantityId = 000000001,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Antari"),
                    Model = models.Single(s => s.ModelName == "W515"),
                    total = 0,
                    InUse = 0
                },
                  new Quantities{
                    QuantityId = 000000002,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "G300"),
                    total = 0,
                    InUse = 0
                },
                new Quantities{
                    QuantityId = 000000003,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Cubix 6 - CX6"),
                    total = 0,
                    InUse = 0
                },
                new Quantities{
                    QuantityId = 000000004,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Peavey"),
                    Model = models.Single(s => s.ModelName == "Escort 3000 - PE3000"),
                    total = 0,
                    InUse = 0
                },
                new Quantities{
                    QuantityId = 000000005,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Antari"),
                    Model = models.Single(s => s.ModelName == "Ice 101"),
                    total = 0,
                    InUse = 0
                },
                new Quantities{
                    QuantityId = 000000006,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "MK2 G300"),
                    total = 0,
                    InUse = 0
                },
                new Quantities{
                    QuantityId = 000000007,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Martin"),
                    Model = models.Single(s => s.ModelName == "Jem"),
                    total = 0,
                    InUse = 0
                },
                new Quantities{
                    QuantityId = 000000010,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Cloud36"),
                    total = 0,
                    InUse = 0
                },
                new Quantities{
                    QuantityId = 000000011,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Cloud24"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000011,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "SNJ110"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000012,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "DNJ110"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000013,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Moka Lighting"),
                    Model = models.Single(s => s.ModelName == "Single Jet"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000014,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "SNG"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000015,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "DNG"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000016,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Haze2D"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000007,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Haze Baze"),
                    Model = models.Single(s => s.ModelName == "Base110"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000018,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "G300Haze"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000019,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Lemaitre"),
                    Model = models.Single(s => s.ModelName == "Radiance"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000020,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Reel Efx"),
                    Model = models.Single(s => s.ModelName == "DF50"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000021,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "ICC110"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000022,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "3sGerb"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000023,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "6LGerb"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000024,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "NPC30"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000025,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "NPG"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000026,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Silent Snow - SS3"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000027,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Global Special Effects"),
                    Model = models.Single(s => s.ModelName == "T1500 Mini - BSZ"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000028,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Pro Snow - SM250"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000029,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Global Truss"),
                    Model = models.Single(s => s.ModelName == "10 Foot Aluminum - SQ414"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000030,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "Chauvet"),
                    Model = models.Single(s => s.ModelName == "Bubble King - BK110"),
                },
                 new Quantities{
                     QuantityId = 000000031,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Foam Monster - FM110"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000032,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Mini Foam Cannon - MFC110"),
                    total = 0,
                    InUse = 0
                },
                 new Quantities{
                     QuantityId = 000000033,
                    Vendor = vendors.Single(s => s.VendorName == "Atlanta Special FX"),
                    Make = makes.Single(s => s.MakeName == "ATL Special FX"),
                    Model = models.Single(s => s.ModelName == "Extreme Foam Machine - EFM110"),
                    total = 0,
                    InUse = 0
                },
            };


            foreach (Quantities q in quantities)
            {
                q.total += 1;
                q.InUse += 1;                  
            }  
           // quantities.ForEach(s => context.Quantities.AddOrUpdate(p => p.QuantityId, s));

            
            foreach (Assets a in assets)
            {                
                var part1 = (a.Vendor.VendorId + 1000).ToString();                
                var part4 = (10000000 + a.AssetId).ToString();             
                a.Barcode = part1.Substring(1) + part4.Substring(1);
            }
            //assets.ForEach(s => context.Assets.AddOrUpdate(p => p.AssetId, s));


            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            string[] roleNames = { "Admin", "Vendor", "Preferred Customer", "Customer" };
            IdentityResult roleResult;
            foreach(var roleName in roleNames)
            {
                if (!RoleManager.RoleExists(roleName))
                {
                    //roleResult = RoleManager.Create(new IdentityRole(roleName));
                }
            }

            var warehouses = new List<VendorWarehouses>
            {
                new VendorWarehouses {VendorWarehouseId = 01,
                    Address = "519 Hurricane Shoals Road, Bld 2, Unit G",
                    City = "Lawrenceville",
                    Region = "GA",
                    CountryCode = "US",
                    PostalCode = "30046",
                    Latitude = Convert.ToDecimal(33.978409),
                    Longitude = Convert.ToDecimal(-83.974508),
                    Vendor = vendors.Single(s => s.VendorId == 1)}
                
            };
            //warehouses.ForEach(s => context.VendorWarehouses.AddOrUpdate(p => p.VendorWarehouseId, s));


        }


    }
}