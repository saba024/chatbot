using System;
namespace chatbot.Models
{
    public class Order
    { 
        public int OrderId { get; set; }
        public string User { get; set; } // имя фамилия покупателя
        public string Address { get; set; } // адрес покупателя
        public string ContactPhone { get; set; } // контактный телефон покупателя

        public int DishId { get; set; } // ссылка на связанную модель Dish
        public Dish Dish { get; set; }

        public Order()
        {
        }
    }
}
