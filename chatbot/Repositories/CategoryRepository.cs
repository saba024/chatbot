 using System;
using System.Collections.Generic;
using chatbot.Interfaces;
using chatbot.Data;
using chatbot.Models;
using Microsoft.EntityFrameworkCore;

namespace chatbot.Repositories
{
    public class CategoryRepository : IDishCategory
    {
        private readonly DishContext dishContext;
        public CategoryRepository(DishContext dishContext)
        {
            this.dishContext = dishContext;
        }

        public IEnumerable<Category> GetCategories => dishContext.Categories;
    }
}
