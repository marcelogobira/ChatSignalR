using System;

namespace Chat.Models
{
    public class User
    {
        public string Name { get; set; }
        public Int64 Key { get; set; }
        public DateTime ConnectionDate { get; set; }
    }
}