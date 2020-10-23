using System;
using System.Collections.Generic;

namespace chatbot.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Category_name { get; set; }
        public string Img { get; set; }
        public List<Dish> Dish { get; set; }

        public Category()
        {
        }
    }
}
