using System.Linq;
using System.Collections.Generic;
using chatbot.Commands;
using chatbot.Data;
using chatbot.Interfaces;
using chatbot.Models;
using Microsoft.EntityFrameworkCore;

namespace chatbot.Services
{
    public class CommandService : ICommandService
    {
        private readonly List<TelegramCommand> _commands;
        
       
        
        public CommandService()
        {
            
            _commands = new List<TelegramCommand>
            {
                new AboutCommand(),
                new BeginCommand(),
                new ReviewCommand(),
                new StartCommand(),
                
            };
        }

        

        public List<TelegramCommand> Get() => _commands;

        
    }
}
