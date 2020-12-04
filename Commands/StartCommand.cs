using System;
using System.Threading.Tasks;
using chatbot.Data;
using chatbot.Interfaces;
using chatbot.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace chatbot.Commands
{
    public class StartCommand : TelegramCommand
    {

        public override string Name => @"/start";
        public readonly ApplicationDbContext _db;
        private readonly UserManager<User> _userManager;

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
            {
                return false;
            }

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, ITelegramBotClient client)
        {
            
            var chatId = message.Chat.Id;
            var nm = message.Chat.FirstName;
           

            var keyboard = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("\U0001F3E0 Главная")
                    },
                }

            };

            await client.SendTextMessageAsync(chatId, "Добро пожаловать в наш ресторан!" + "Здесь посмотреть меню и оформить заказ.",
                parseMode: ParseMode.Html, false, false, 0, keyboard);
        }
    }
}
