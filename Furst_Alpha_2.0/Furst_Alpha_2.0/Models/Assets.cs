using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.ComponentModel.DataAnnotations.Schema;


namespace Furst_Alpha_2._0.Models
{
    public class Assets
    {
        [Key]
        public int AssetId { get; set; }

        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }

        public virtual Vendors Vendor { get; set; }
        public virtual Categories Category { get; set; }
        public virtual Types Type { get; set; }
        public virtual Makes Make { get; set; }
        public virtual Models Model { get; set; }

        public string Barcode { get; set; }
        public int YearPurchased { get; set; }
        public double RentalPrice { get; set; }
        public int NumTechsReq { get; set; }
        public bool Availability { get; set; }

    }
}