﻿using System;
using System.Collections.Generic;
using System.Text;
using chatbot.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace chatbot.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TelegramUser> TelegramUser { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
