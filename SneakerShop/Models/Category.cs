using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SneakerShop.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Sneaker Description")]
        public string Description { get; set; }
        public virtual ICollection<Sneaker> Sneakers { get; set; }
        public virtual ICollection<Shirt> Shirts { get; set; }
    }
}