using System;
using Microsoft.EntityFrameworkCore;
using chatbot.Models;

namespace chatbot.Data
{
    public class DishContext : DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DishContext(DbContextOptions<DishContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        
    }
}
