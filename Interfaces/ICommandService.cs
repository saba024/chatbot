using System;
using System.Collections.Generic;
using chatbot.Models;

namespace chatbot.Interfaces
{
    public interface ICommandService
    {
        List<TelegramCommand> Get();
    }
}
