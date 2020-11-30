using System;
using System.Collections.Generic;
using chatbot.Interfaces;
using chatbot.Models;

namespace chatbot.Mocks
{
    public class MockTelegramUser : ITelegramUser
    {
        TelegramUser telegramuser = new TelegramUser();

        public IEnumerable<TelegramUser> GetUsers
        {
            get
            {
                return new List<TelegramUser> {
                    new TelegramUser
                    {
                        Id = telegramuser.Id
                    }
                };
            }
        }

        public void AddMessage(string Text)
        {
            telegramuser.Messages.Add(Text);
        }

        public bool Equals(TelegramUser other)
        {
            return other.Id == telegramuser.Id;
        }
    }
}