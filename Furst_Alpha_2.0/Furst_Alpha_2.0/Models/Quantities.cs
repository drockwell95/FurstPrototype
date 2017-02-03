using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_2._0.Models
{
    public class Quantities
    {
        [Key]
        public int QuantityId { get; set; }
        public virtual Vendors Vendor { get; set; }
        public virtual Makes Make { get; set; }
        public virtual Models Model { get; set; }


        public int total { get; set; }
        public int InUse { get; set; }

    }
}