using System;
using System.Collections.Generic;
using chatbot.Models;

namespace chatbot.Interfaces
{
    public interface IGetDish
    {
        IEnumerable<Dish> GetDishes { get;  }
        IEnumerable<Dish> GetFavDish { get; set; }
        Dish GetObjectdish(int dishId);
    }
}
