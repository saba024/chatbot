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

namespace chatbot.Controllers
{
    public class AnnouncmentController : Controller
    {
       
        

        public AnnouncmentController()
        {
            
        }



        public IActionResult Index([FromForm] string message)
        {

            return View();
        }

       

        [HttpPost("/announcment")]
        public IActionResult Post([FromForm] string body, string message)
        {
            var msg = new MimeMessage();
            List<string> recepients = new List<string>() { "naskidashvilisaba370@gmail.com" };
            if (EmailClass.recepients != null)
            {
                recepients.Add(EmailClass.recepients);
            }
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
                client.Connect("smtp.gmail.com", 25, false);

                client.Authenticate("naskidashvilisaba370@gmail.com", "madrid2016");

                client.Send(msg);
                client.Disconnect(true);
            }

            return RedirectToAction("Index");
        }
    }
}