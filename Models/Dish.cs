using System;
namespace chatbot.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Img { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsAvailable { get; set; }
        public int Category_id { get; set; }
        public Category Category { get; set; }
    }

}
