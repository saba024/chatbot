using System;
using System.Collections.Generic;
using chatbot.Interfaces;
using chatbot.Models;
using System.Linq;

namespace chatbot.Mocks
{
    public class MockDish : IGetDish
    {
        private readonly IDishCategory _dishCategory = new MockCategory();

        public IEnumerable<Dish> GetDishes {
            get
            {
                return new List<Dish>
                {
                    new Dish{Name = "Континентальный завтрак", Description="Колбаса гриль из курицы ,яйцо куриное, картофельные котлетки Хашбраун, фасоль красная консерв., томаты бланшированные", Img = "/img/kontinent.jpg", Price=8.10, IsFavourite = true, IsAvailable=true, Category=_dishCategory.GetCategories.First()}
                };
            }
        }
        public IEnumerable<Dish> GetFavDish { get; set; }

        public Dish GetObjectdish(int dishId)
        {
            throw new NotImplementedException();
        }
    }
}

