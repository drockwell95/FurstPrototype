﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_2._0.Models
{
    public class Vendors
    {
        [Key]
        [Range(0, 999)]
        public int VendorId { get; set; }
        public string VendorName { get; set; }

        public ICollection<Assets> Assets { get; set; }
    }
}