using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Telegram.Bot;

namespace chatbot.Hubs
{
    public class MessageHub : Hub
    {
        /* private readonly ITelegramBotClient _telegramBotClient;

         MessageHub() { }

         MessageHub(ITelegramBotClient telegramBotClient)
         {
             _telegramBotClient = telegramBotClient;
         }*/

        public Task SendMessageToAll(string message)
        {
            //await _telegramBotClient.SendTextMessageAsync(,message);
            return Clients.All.SendAsync("ReceiveMessage", message);
        }

        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.SendAsync("ReceiveMessage", message);
        }

        public Task SendMessageToUser(string connectionId, string message)
        {
            return Clients.Client(connectionId).SendAsync("ReceiveMessage", message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnected", Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
            await base.OnDisconnectedAsync(ex);
        }
    }
}