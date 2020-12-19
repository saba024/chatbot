using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatbot.Hubs;
using chatbot.Interfaces;
using chatbot.Models;
using Microsoft.AspNetCore.Mvc;

using Telegram.Bot;
using Telegram.Bot.Types;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using chatbot.Services;

namespace chatbot.Controllers
{
    public class AnnouncmentController : Controller
    {

        private readonly IEmailMessanger _emailMessenger;

        public AnnouncmentController(IEmailMessanger emailMessenger)
        {
            _emailMessenger = emailMessenger;
        }


        public IActionResult Index([FromForm] string message)
        {

            return View();
        }


        [HttpPost("/announcment")]
        public IActionResult Post([FromForm] string body, string message)
        {
            EmailMessage msg = new EmailMessage
            {
                From = "chatbot Admin",
                Subject = body,
                Content = message
            };

            List<string> recepients = new List<string>() { "naskidashvili.2001@mail.ru" };
            if (EmailClass.recepients != null)
            {
                recepients.Add(EmailClass.recepients);
            }

            foreach (var rec in recepients)
            {
                msg.ToAddresses.Add(rec);
            }

            _emailMessenger.SendMsg(msg);

            return RedirectToAction("Index");
        }
    }
}