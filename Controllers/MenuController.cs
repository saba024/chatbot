using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatbot.Interfaces;
using chatbot.Models;
using chatbot.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace chatbot.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;
        private readonly IGetDish _getDish;
        private readonly IDishCategory _dishCategory;


        public MenuController(ILogger<MenuController> logger, IDishCategory dishCategory, IGetDish getDish)
        {
            _logger = logger;
            _dishCategory = dishCategory;
            _getDish = getDish;
        }

        [Route("Menu/List")]
        [Route("Menu/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Dish> dishes;
            
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                dishes = _getDish.GetDishes.OrderBy(i => i.Id);
            }

            else
            {
                if (string.Equals("breakfast", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _getDish.GetDishes.Where(i => i.Category.Category_name.Equals("Breakfast")).OrderBy(i => i.Id);
                }

                else if (string.Equals("lunch", category, StringComparison.OrdinalIgnoreCase))
                {
                    dishes = _getDish.GetDishes.Where(i => i.Category.Category_name.Equals("Lunch")).OrderBy(i => i.Id);
                }

                else dishes = _getDish.GetDishes.Where(i => i.Category.Category_name.Equals("Desert")).OrderBy(i => i.Id);

                currCategory = _category;
            }



            var dishObj = new DishListViewModel
            {
                AllDishes = dishes,
                CurrentCategory = currCategory
            };

            return View(dishObj);
        }
    }
}