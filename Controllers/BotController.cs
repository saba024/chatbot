using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using chatbot.Data;
using chatbot.Hubs;
using chatbot.Interfaces;
using chatbot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Telegram.Bot;
using Telegram.Bot.Types;
using Microsoft.EntityFrameworkCore;

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
        private MessageHub _hub;
        

        public BotController(ICommandService commandService, ITelegramBotClient telegramBotClient, IHubContext<MessageHub> hubcontext, MessageHub hub)
        {
            _commandService = commandService;
            _telegramBotClient = telegramBotClient;
            _hubcontext = hubcontext;
            _hub = hub;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Started");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            if (update == null) return Ok();

            var message = update.Message;

            foreach (var comm in _commandService.Get())
            {
                if (comm.Contains(message))
                {
                    await comm.Execute(message, _telegramBotClient);
                    break;
                }
            }


            await _hubcontext.Clients.All.SendAsync("ReceiveMessage", message.Text);
            return Ok();
        }
    }
}
