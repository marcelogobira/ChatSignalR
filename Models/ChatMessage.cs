using System.Reflection.Metadata;
using System;

namespace Chat.Models
{
    public class ChatMessage
    {
        public Int64 Destination { get; set; }
        public User Sender { get; set; }
        public string Message { get; set; }
    }
}