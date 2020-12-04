using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using chatbot.Models;
using Telegram.Bot;

namespace chatbot.Controllers
{
    public class ChatController : Controller
    {
        private readonly ITelegramBotClient _telegramBotClient;

        public ChatController(ITelegramBotClient telegramBotClient)
        {
            _telegramBotClient = telegramBotClient;
        }

        [Authorize(Roles = RoleNames.Administrator)]
        public IActionResult Index()
        {
            return View();
        }   

       [HttpPost("/chat")]
       public async Task<IActionResult> Send([FromForm] string message)
       {
           int chatid = 310145490;
           Console.WriteLine(message);
           await _telegramBotClient.SendTextMessageAsync(chatid, message);

           return RedirectToAction("Chat");
       }
    }
}
