using System;
using System.Collections.Generic;

namespace chatbot.Interfaces
{
    public interface ICommandService
    {
        List<TelegramCommand> Get();
    }
}
