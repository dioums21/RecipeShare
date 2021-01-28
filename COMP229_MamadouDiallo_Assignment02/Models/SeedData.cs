using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_MamadouDiallo_Assignment02.Models
{
    public static class SeedData
    {
        public static void InitialData(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        Name = "Crepes",
                        Description = "Breakfast",
                        Ingredients = "Eggs, sugar, milk and flour",
                        Chef = "Michael",
                        PreparationTime = 10
                    },
                    new Recipe
                    {
                        Name = "Soup",
                        Description = "Dinner",
                        Ingredients = "Water, broth, onions, tomato",
                        Chef = "James",
                        PreparationTime = 30
                    },
                    new Recipe
                    {
                        Name = "Taco",
                        Description = "Brunch",
                        Ingredients = "Nachos, sour cream, salsa, cheese, avocado",
                        Chef = "Neymar",
                        PreparationTime = 5
                    },
                    new Recipe
                    {
                        Name = "Burger",
                        Description = "Lunch",
                        Ingredients = "Buns, lettuce, pickles, tomato, patty",
                        Chef = "John",
                        PreparationTime = 6
                    },
                    new Recipe
                    {
                        Name = "Fried Chicken",
                        Description = "Dinner",
                        Ingredients = "Flour, chicken, buttermilk, salt, pepper",
                        Chef = "Mamadou",
                        PreparationTime = 40
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
