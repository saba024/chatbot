using System;
namespace chatbot.Models
{
    public class Order
    { 
        public int Id { get; set; }
        public string User { get; set; }
        public string Address { get; set; } 
        public string ContactPhone { get; set; } 

        public string DishId { get; set; } 
        public Dish Dish { get; set; }

    }
}
