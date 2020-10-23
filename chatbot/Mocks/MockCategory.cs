using System;
using System.Collections.Generic;
using chatbot.Interfaces;
using chatbot.Models;

namespace chatbot.Mocks
{
    public class MockCategory: IDishCategory
    {
        
        public IEnumerable<Category> GetCategories
        {
            get {
                return new List<Category> {
                    new Category { Category_name = "Breakfast", Id = 0},
                    new Category { Category_name = "Lunch"},
                    new Category { Category_name = "Evening"},
                    new Category { Category_name = "Desert"}
                };
            } 
        }
    }
}
