using System;
using Microsoft.EntityFrameworkCore;
namespace chatbot.Models
{
    public class DishContext: DbContext
    {
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set;}

        public DishContext(DbContextOptions<DishContext> options): base(options)
        {
            Database.EnsureCreated();
        }
         
    }
}
