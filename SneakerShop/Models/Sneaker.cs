using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SneakerShop.Models
{
    public class Sneaker
    {
        [ScaffoldColumn(false)]
        public int SneakerID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string SneakerName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}