using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using chatbot.Data;
using chatbot.Interfaces;
using chatbot.Mocks;
using chatbot.Services;
using Newtonsoft.Json.Serialization;
using FluentValidation.AspNetCore;
using chatbot.Hubs;
using chatbot.Repositories;
using Microsoft.Extensions.Logging;
using System.IO;
using chatbot.logs;
using chatbot.Models;

namespace chatbot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DishContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<PanelDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PanelDbConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(opt =>
            {
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 5;
                opt.Password.RequireUppercase = true;
                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedAccount = false;
            })
              .AddRoles<IdentityRole>()
              .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentity<TelegramUser, IdentityRole>()
               .AddEntityFrameworkStores<PanelDbContext>();



            services.AddControllersWithViews();
            services.AddTransient<IGetDish, DishRepository>();
            services.AddTransient<IDishCategory, CategoryRepository>();

            services
               .AddScoped<ICommandService, CommandService>()
               //.AddScoped<IDbRepository, DbRepository>()
               .AddTelegramBotClient(Configuration)
               .AddControllers()
               .AddNewtonsoftJson(options =>
               {
                   options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                   options.SerializerSettings.ContractResolver = new DefaultContractResolver();
               })
               .AddFluentValidation();
            services.AddMvc();
            services.AddSignalR();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

           

            app.UseRouting();

            

            app.UseAuthentication();
            app.UseAuthorization();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MessageHub>("/messages");
            });

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "categoryFilter",
                    pattern: "Dish/{action}/{category?}", defaults: new { Controller = "Dish", action = "List" });

                endpoints.MapRazorPages();
            });

            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), Configuration.GetSection("AllLog").Value),
                Path.Combine(Directory.GetCurrentDirectory(), Configuration.GetSection("ErrorLog").Value));
            var logger = loggerFactory.CreateLogger("FileLogger");

            using (var scope = app.ApplicationServices.CreateScope())
            {
                DishContext context = scope.ServiceProvider.GetRequiredService<DishContext>();
                DBObjects.Initial(context);
            }


        }
    }
}