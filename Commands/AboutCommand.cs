using System;
using System.Threading.Tasks;
using chatbot.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace chatbot.Commands
{
    public class AboutCommand : TelegramCommand
    {
        public override string Name { get; } = "График работы";

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

            await client.SendTextMessageAsync(chatId, "Наш ресторан..." + "График работы:",
                parseMode: ParseMode.Html, replyMarkup: keyboard );
        }
    }
}
