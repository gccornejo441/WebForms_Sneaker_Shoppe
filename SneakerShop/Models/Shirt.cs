using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SneakerShop.Models
{
    public class Shirt
    {
        [ScaffoldColumn(false)]
        public int ShirtID { get; set; }
        [Required, StringLength(100), Display(Name = "Shirt Name")]
        public string ShirtName { get; set; }
        [Required]
        public string Description { get; set; }
        public string ShirtImageUrl { get; set; }
        public double? ShirtPrice { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}