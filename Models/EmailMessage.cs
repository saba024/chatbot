using System;
using System.Collections.Generic;

namespace chatbot.Models
{
    public class EmailMessage
    {
        public List<string> ToAddresses { get; set; } = new List<string>();
        public string From { get; set; } = "chatBot Panel";
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
