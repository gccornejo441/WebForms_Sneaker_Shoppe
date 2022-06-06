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
            GetShirts().ForEach(c => context.Shirts.Add(c));
        }

        private static List<Shirt> GetShirts()
        {
            var shirts = new List<Shirt>
            {
                new Shirt
                {
                    ShirtID = 1,
                    ShirtName = "Mock 1",
                    ShirtImageUrl = "Mock-1.jpg",
                    ShirtPrice = 59.99,
                    Description = "This is a mock t-shirt"
                }
            };
            return shirts;
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
                    SneakerName = "Nike Blazer Mid '77 Vintage",
                    Description = "In the ‘70s, Nike was the new shoe on the block. So new in fact, we were still breaking into the basketball scene and testing prototypes on the feet of our local team. Of course, the design improved over the years, but the name stuck. The Nike Blazer Mid ’77 Vintage—classic since the beginning.",
                    ImagePath = "nike-blazer-mid-77.png",
                    UnitPrice = 100.00,
                    CategoryID = 1
                },
                new Sneaker
                {
                    SneakerID = 2,
                    SneakerName = "Air Jordan 1 Mid",
                    Description = "Inspired by the original AJ1, the Air Jordan 1 Mid offers fans a chance to follow in MJ's footsteps. Fresh color trims the clean, classic materials, imbuing modernity into a classic design.",
                    ImagePath = "air-jordan-1-mid.png",
                    UnitPrice = 120.00,
                    CategoryID = 2
                },
                new Sneaker
                {
                    SneakerID = 3,
                    SneakerName = "Nike React Infinity Run Flyknit 3",
                    Description = "Still our most tested shoe, made to help you stay after those lofty running goals. The Nike React Infinity Run 3 feels soft and stable with a smooth ride that carries you through routes, long and short. A breathable upper is made to feel contained, yet flexible. We even added more cushioning around the heel and ankle for a supportive sensation. Keep running, we've got you.",
                    ImagePath = "nike-react-infinity-run-flyknit-3.png",
                    UnitPrice = 160.00,
                    CategoryID = 3
                },
                new Sneaker
                {
                    SneakerID = 4,
                    SneakerName = "Nike Air Zoom G.T. Jump",
                    Description = "Feel like defying gravity? Meet one of Nike Basketball’s most responsive cushioning systems ever devised for game shoes. The double-stacked Zoom Air works in unison with an external jump frame made from PEBAX® that's lightweight, springy and strong. The woven exoskeleton-like upper helps you feel fully connected, so you can move with confidence and power and defeat the force that holds you down.",
                    ImagePath = "nike-air-zoom-gt-jump.png",
                    UnitPrice = 180.00,
                    CategoryID = 4
                }
            };
            return sneakers;
        }
    }
}