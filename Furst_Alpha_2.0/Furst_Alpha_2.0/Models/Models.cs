using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Furst_Alpha_2._0.Models
{
    public class Models
    {
        [Key]
        [Range(0, 99)]
        public int ModelId { get; set; }
        public string ModelName { get; set; }

        public ICollection<Assets> Assets { get; set; }
    }
}