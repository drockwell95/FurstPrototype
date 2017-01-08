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
        public Vendors Vendor { get; set; }
        public Categories Category { get; set; }
        public Types Type { get; set; }
        public Makes Make { get; set; }
        public Models Model { get; set; }

        public string Barcode { get; set; }
        public string Image { get; set; }
        public int YearPurchased { get; set; }
        public double RentalPrice { get; set; }
        public int NumTechsReq { get; set; }
        public bool Availability { get; set; }

    }
}