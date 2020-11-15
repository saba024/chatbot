using System;
using System.Collections.Generic;
using System.Linq;
using chatbot.Interfaces;
using chatbot.Data;
using chatbot.Models;
using Microsoft.EntityFrameworkCore;

namespace chatbot.Repositories
{
    public class DishRepository : IGetDish
    {
        private readonly DishContext dishContext;

        public DishRepository(DishContext dishContext)
        {
            this.dishContext = dishContext;
        }

        public IEnumerable<Dish> GetDishes => dishContext.Dishes.Include(c => c.Category);

        public IEnumerable<Dish> GetFavDish => dishContext.Dishes.Where(p => p.IsFavourite).Include(p => p.Category);

        public Dish GetObjectdish(int dishId) => dishContext.Dishes.FirstOrDefault(p => p.Id == dishId);
    }
}
