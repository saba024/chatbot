using System;
using System.Collections.Generic;
using chatbot.Models;

namespace chatbot.Interfaces
{
    public interface ITelegramUser
    {
        public bool Equals(TelegramUser other);

        public void AddMessage(string Text);

        IEnumerable<TelegramUser> GetUsers { get; }


    }
}
