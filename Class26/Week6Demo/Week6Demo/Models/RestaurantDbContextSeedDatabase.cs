using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week6Demo.Data;

namespace Week6Demo.Models
{
    public static class RestaurantDbContextSeedDatabase
    {
        static object synchblock = new object();
        static volatile bool seeded = false;
        public static void EnsureSeedData(this RestaurantDbContext context)
        {
            if (!seeded && context.Restaurant.Count() == 0)
            {
                lock (synchblock)
                {
                    if (!seeded)
                    {
                        var restaurants = GenerateRestaurants();
                        context.Restaurant.AddRange(restaurants);
                        context.SaveChanges();
                        seeded = true;
                    }
                }

            }
        }

        public static Restaurant GenerateRestaurants()
        {
            return new Restaurant
            {
                Name = "Biscuit Bitch",
                Description = "Southern Inspired Fixins",
                MenuItems = string.Join(Environment.NewLine, new List<string> {
                        "Biscuits",
                        "Gravy",
                        "Coffee",
                    }),
                StarRating = 3,
                ImageUrl = "/Images/BB.jpg",

                new Restaurant
                {
                    Name = "Portage Bay Cafe",
                    Description = "Eat like you give a Damn!",
                    MenuItems = string.Join(Environment.NewLine, new List<string> {
                        "Gluten Free French Toast",
                        "Omlettes",
                        "Gluten-Free Pancakes",
                        "Full pitcher of Mimosas",

                    }),
                    ImageURL = "/Images/portage-bay-logo.jpg",

                    StarRating = 5,
                },
                new Restaurant
                {
                    Name = "I Love My GFF",
                    Description = "Food Cart that shows up randomly around Seattle",
                    MenuItems = string.Join(Environment.NewLine, new List<string> {
                        "GF Coconut Cookies",
                        "Fiest Chicken and Quiona bowls",
                        "Vegan Sunshine Bowl",
                    }),
                    ImageURL = "/Images/GFF.jpg",
                    StarRating = 5,
                },
            }
        
            }



    }
}
}
