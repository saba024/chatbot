using System;
using System.Collections.Generic;
using System.Text;
using chatbot.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace chatbot.Data
{
    public class PanelDbContext : IdentityDbContext
    {
        public DbSet<TelegramUser> TelegramUser { get; set; }
        public PanelDbContext(DbContextOptions<PanelDbContext> options)
            : base(options)
        {
        }
    }
}
