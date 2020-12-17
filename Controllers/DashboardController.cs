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
using System.Collections.ObjectModel;
using chatbot.Data;
using Microsoft.AspNetCore.Authorization;

namespace chatbot.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetDish _getDish;
        private readonly IDishCategory _dishCategory;
        private readonly DishContext _db;
        private readonly PanelDbContext _db1;

        public DashboardController(ILogger<HomeController> logger, IDishCategory dishCategory, IGetDish getDish, DishContext db, PanelDbContext context)
        {
            _logger = logger;
            _dishCategory = dishCategory;
            _getDish = getDish;
            _db = db;
            _db1 = context;
        }


        
        public IActionResult Index()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            dashboardViewModel.dish_count = _db.Dishes.Count();
            dashboardViewModel.category_count = _db.Categories.Count();
            dashboardViewModel.users_count = _db1.Users.Count();
            _logger.LogInformation("Getting all dish");
            return View(dashboardViewModel);
        }

        
        public IActionResult Chat()
        {

            return View();
        }


        [HttpPost("dish/list")]
        public IActionResult Add([FromForm] string email)
        {
            EmailClass.recepients = email;
            _logger.LogInformation("Subscribe by email");
            return RedirectToAction("Index");
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