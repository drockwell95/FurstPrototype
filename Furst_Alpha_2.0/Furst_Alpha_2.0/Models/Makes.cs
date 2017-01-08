using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_2._0.Models
{
    public class Makes
    {
        [Key]
        [Range(0, 99)]
        public int MakeId { get; set; }
        public string MakeName { get; set; }

        public ICollection<Assets> Assets { get; set; }
    }
}