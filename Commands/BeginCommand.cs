using System;
using System.Threading.Tasks;
using chatbot.Interfaces;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace chatbot.Commands
{
    public class BeginCommand : TelegramCommand
    {

        public override string Name { get; } = "\U0001F3E0 Главная";

        public override bool Contains(Message message)
        {
            if(message.Type != MessageType.Text)
            {
                return false;
            }

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, ITelegramBotClient client)
        {
            var chatId = message.Chat.Id;
           

            var inlineKeyboard = new InlineKeyboardMarkup(new[] {

                        new []
                        {
                        InlineKeyboardButton.WithUrl("Открыть Меню", "https://professorweb.ru/my/ASP_NET/mvc/level1/"),
                        },

                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData("О ресторане"),
                            InlineKeyboardButton.WithCallbackData("Оставить отзыв"),
                        },

                        new []
                        {
                        InlineKeyboardButton.WithUrl("Личный кабинет", "https://professorweb.ru/my/ASP_NET/mvc/level1/"),
                        },
                    });

            await client.SendTextMessageAsync(chatId, "https://siabry.by/uploads/App/Entity/Image/64a97d264d423a7ed5a1da3f32a02aa170f2da9e.jpeg",
                parseMode: ParseMode.Html, replyMarkup: inlineKeyboard);
        }
    }
}
