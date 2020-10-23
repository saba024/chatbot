using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chatbot.Models;
using chatbot.Interfaces;
using chatbot.ViewModels;

namespace chatbot.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetDish _getDish;
        private readonly IDishCategory _dishCategory;

        public HomeController(ILogger<HomeController> logger, IDishCategory dishCategory, IGetDish getDish)
        {
            _logger = logger;
            _dishCategory = dishCategory;
            _getDish = getDish;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            DishListViewModel obj = new DishListViewModel();
            obj.AllDishes = _getDish.GetDishes;
            obj.CurrentCategory = "Breakfast";
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
