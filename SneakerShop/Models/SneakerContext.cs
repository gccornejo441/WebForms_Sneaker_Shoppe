using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SneakerShop.Models
{
    public class SneakerContext : DbContext
    {
        public SneakerContext() : base("SneakerShop")
        {

        }

        public DbSet<Shirt> Shirts { get; set; }

        public DbSet<Sneaker> Sneakers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}