using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using chatbot.Hubs;
using chatbot.Interfaces;
using chatbot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace chatbot.Controllers
{
    [ApiController]
    [Route("api/message/update")]
    public class BotController : Controller
    {
        private readonly ITelegramBotClient _telegramBotClient;
        private readonly ICommandService _commandService;
        ObservableCollection<TelegramUser> Users;
        private IHubContext<MessageHub> _hubcontext;

        public BotController(ICommandService commandService, ITelegramBotClient telegramBotClient, IHubContext<MessageHub> hubcontext)
        {
            _commandService = commandService;
            _telegramBotClient = telegramBotClient;
            _hubcontext = hubcontext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Started");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            string recmessage = "";
            if (update == null) return Ok();

            var message = update.Message;

            foreach (var command in _commandService.Get())
            {
                if (command.Contains(message))
                {
                    await command.Execute(message, _telegramBotClient);
                    break;
                }
            }

            Users = new ObservableCollection<TelegramUser>();

            _telegramBotClient.OnMessage += delegate(object sender, Telegram.Bot.Args.MessageEventArgs e)
            {
                string msg = $"{DateTime.Now}:{e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";
                recmessage = msg;
                Debug.WriteLine(msg);
                
                var person = new TelegramUser(e.Message.Chat.FirstName, e.Message.Chat.Id);
                if (!Users.Contains(person)) Users.Add(person);
                Users[Users.IndexOf(person)].AddMessage($"{person.Nick}:{e.Message.Text}");
                _telegramBotClient.StartReceiving();
            
            };
            await _hubcontext.Clients.All.SendAsync("ReceiveMessage", recmessage);
            return Ok();
        }
    }
}
