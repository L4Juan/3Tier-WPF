using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Message
    {
        public Message(string message)
        {
            MessageContent = message;
        }
        public string MessageContent { get; set; }
    }
}
