using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatbot.Hubs;
using chatbot.Interfaces;
using chatbot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Telegram.Bot;
using Telegram.Bot.Types;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace chatbot.Controllers
{
    public class AnnouncmentController : Controller
    {
        private IHubContext<MessageHub> _hubcontext;
        private readonly ITelegramBotClient _telegramBotClient;
        private readonly ICommandService _commandService;
        private readonly ITelegramUser _telegramUser;

        public AnnouncmentController(IHubContext<MessageHub> hubcontext, ICommandService commandService, ITelegramBotClient telegramBotClient, ITelegramUser telegramUser)
        {
            _hubcontext = hubcontext;
            _commandService = commandService;
            _telegramBotClient = telegramBotClient;
            _telegramUser = telegramUser;
        }

        
        
        public IActionResult Index([FromForm] string message)
        {
            
            return View();
        }

        /*[HttpPost("/announcment")]
        public async Task<IActionResult> Post([FromForm] string message)
        {
            int chatid = 310145490;
            await _telegramBotClient.SendTextMessageAsync(chatid, message);
            await _hubcontext.Clients.All.SendAsync("ReceiveMessage", message);
            
            return RedirectToAction("Index");
        }*/

        [HttpPost("/announcment")]
        public IActionResult Post([FromForm] string body, string message)
        {
            var msg = new MimeMessage();
            List<string> recepients = new List<string> () { "naskidashvilisaba370@gmail.com"};
            recepients.Add(EmailClass.recepients);
            msg.From.Add(new MailboxAddress("Admin", "naskidashvilisaba370@gmail.com"));
            foreach (var rec in recepients)
            {
                msg.To.Add(new MailboxAddress("Training academy", rec));
            }
            
            msg.Subject = body;
            msg.Body = new TextPart("plain")
            {
                Text = message

            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("naskidashvilisaba370@gmail.com", "madrid2016");

                client.Send(msg);
                client.Disconnect(true);
            }

            return RedirectToAction("Index");
        }
    }
}
