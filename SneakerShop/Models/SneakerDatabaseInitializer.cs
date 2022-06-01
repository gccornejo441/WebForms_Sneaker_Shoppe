using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SneakerShop.Models
{
    public class SneakerDatabaseInitializer : DropCreateDatabaseIfModelChanges<SneakerContext>
    {
        protected override void Seed(SneakerContext context)
        {
            GetSneakers().ForEach(c => context.Sneakers.Add(c));
            GetCategories().ForEach(c => context.Categories.Add(c));
        }

       private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Lifestyle"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Jordan"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Running"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Basketball"
                }
            };
            return categories;
        }

        private static List<Sneaker> GetSneakers()
        {
            var sneakers = new List<Sneaker>
            {
                new Sneaker
                {
                    SneakerID = 1,
                    SneakerName = "Nike Blazer Mid '77 Vintage"
                }
            };
            return sneakers;
        }
    }
}