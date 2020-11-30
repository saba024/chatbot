using System;
using System.Collections.Generic;
using chatbot.Models;

namespace chatbot.ViewModels
{
    public class DishListViewModel
    {
        public IEnumerable<Dish> AllDishes { get; set; }
        public string CurrentCategory { get; set; }

    }
}
