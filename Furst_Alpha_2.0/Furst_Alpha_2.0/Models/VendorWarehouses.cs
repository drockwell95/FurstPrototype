﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_2._0.Models
{
    public class VendorWarehouses
    {
        [Key]
        public int VendorWarehouseId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public Vendors Vendor { get; set; }
    }

    public class NearbyVendorWarehouseLocation : VendorWarehouses
    {
        public decimal AddressLatitude { get; set; }
        public decimal AddressLongitude { get; set; }

        public decimal DistanceFromAddress
        {
            get
            {
                return Convert.ToDecimal(
                         Math.Sqrt(
                               Math.Pow(Convert.ToDouble(this.Latitude - this.AddressLatitude), 2.0)
                                  +
                               Math.Pow(Convert.ToDouble(this.Longitude - this.AddressLongitude), 2.0)
                         )
                         * 62.1371192
                      );
            }
        }

        public string DistanceFromAddressDisplay
        {
            get
            {
                return this.DistanceFromAddress.ToString("0.00 miles");
            }
        }
    }
}