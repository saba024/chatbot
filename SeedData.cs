using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatbot.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace chatbot
{
    public class SeedData
    {
       public static async Task EnsureSeedData(IServiceProvider provider)
        {
            var roleMgr = provider.GetRequiredService<RoleManager<IdentityRole>>();
            foreach (var roleName in RoleNames.AllRoles)
            {
                var role = roleMgr.FindByNameAsync(roleName).Result;

                if(role == null)
                {
                    var result = roleMgr.CreateAsync(new IdentityRole { Name = roleName }).Result;
                    if (!result.Succeeded) throw new Exception(result.Errors.First().Description);
                }
            }

            var userMgr = provider.GetRequiredService<UserManager<TelegramUser>>();

            var adminResult = await userMgr.CreateAsync(DefaultUsers.Administrator, "User123!");

            var userResult = await userMgr.CreateAsync(DefaultUsers.User, "User123!");

            if (adminResult.Succeeded || userResult.Succeeded)
            {
                var adminUser = await userMgr.FindByEmailAsync(DefaultUsers.Administrator.Email);
                var commonUser = await userMgr.FindByEmailAsync(DefaultUsers.User.Email);

                await userMgr.AddToRoleAsync(adminUser, RoleNames.Administrator);
                await userMgr.AddToRoleAsync(commonUser, RoleNames.User);
            }

            
        }
    }

    public static class RoleNames
    {
        public const string Administrator = "Администратор";
        public const string User = "Пользователь";

        public static IEnumerable<string> AllRoles
        {
            get
            {
                yield return Administrator;
                yield return User;
            }
        }
    }

    public static class DefaultUsers
    {
        public static readonly TelegramUser Administrator = new TelegramUser
        {
            Email = "Admin@test.ru",
            EmailConfirmed = true,
            UserName = "Admin@test.ru",
        };

        public static readonly TelegramUser User = new TelegramUser
        {
            Email = "User@test.ru",
            EmailConfirmed = true,
            UserName = "User@test.ru",
        };
    }

}
