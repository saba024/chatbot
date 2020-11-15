using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatbot.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using chatbot.Interfaces;
using chatbot.Mocks;
using chatbot.Repositories;
using chatbot.Data;
using Microsoft.AspNetCore.Http;
using chatbot.Services;
using Newtonsoft.Json.Serialization;
using FluentValidation.AspNetCore;
using chatbot.Hubs;

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
            services.AddControllersWithViews();
            services.AddTransient<IGetDish, MockDish>();
            services.AddTransient<IDishCategory, MockCategory>();
            
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
            services.AddTransient<ITelegramUser, MockTelegramUser>();
            services.AddMvc();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSignalR(config => {
                config.MapHub<MessageHub>("/messages");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
