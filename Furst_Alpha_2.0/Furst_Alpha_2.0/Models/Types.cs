using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_2._0.Models
{
    public class Types
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public ICollection<Assets> Assets { get; set; }
    }
}