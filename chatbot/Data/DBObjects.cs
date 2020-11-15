using System;
using System.Collections.Generic;
using System.Linq;
using chatbot.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace chatbot.Data
{
    public class DBObjects
    {
        public static void Initial(DishContext context)
        {
           
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Dishes.Any())
            {
                context.AddRange(
                    new Dish
                    {
                        Name = "Континентальный завтрак",
                        Description = "Колбаса гриль из курицы ,яйцо куриное, картофельные котлетки Хашбраун, фасоль красная консерв., томаты бланшированные",
                        Img = "/img/kontinent.jpg",
                        Price = 8.10,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Breakfast"]
                    }
                    );
            }

            context.SaveChanges();
        }

        public static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { Category_name = "Breakfast" },
                        new Category {Category_name = "Lunch"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category c in list)
                    {
                        category.Add(c.Category_name, c);
                    }
                }

                return category;     
            }
        }
        
    }
}
