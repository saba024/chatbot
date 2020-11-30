using System.Linq;
using chatbot.Data;
using chatbot.Interfaces;
using chatbot.Models;
using chatbot.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace chatbot.Controllers
{
    public class DishController : Controller
    {
        private readonly DishContext _db;

        public DishController(DishContext db)
        {
            _db = db;
        }

        [Authorize(Roles = RoleNames.Administrator)]
        public ActionResult Index()
        {
            return View(_db.Dishes.ToList());
        }

        [Authorize(Roles = RoleNames.Administrator)]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDish(Dish dish)
        {
            _db.Dishes.Add(dish);
            _db.SaveChanges();
            return RedirectToAction("Index", "Dish");
        }

        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Dish dish = _db.Dishes.Where(s => s.Id == id).First();
                _db.Dishes.Remove(dish);
                _db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public ActionResult Update(int id)
        {
            return View(_db.Dishes.Where(s => s.Id == id).First());
        }

        [HttpPost]
        public ActionResult UpdateDish(Dish dish)
        {
            Dish d = _db.Dishes.Where(s => s.Id == dish.Id).First();
            d.Name = dish.Name;
            d.Category = dish.Category;
            d.Description = dish.Description;
            d.Img = dish.Img;
            d.Price = dish.Price;
            _db.SaveChanges();
            return RedirectToAction("Index", "Dish");
        }
    }
}