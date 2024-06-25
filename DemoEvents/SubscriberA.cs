using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvents
{
    public class SubscriberA
    {
        private readonly SendMessage _sendMessage;
        public SubscriberA(SendMessage sendMessage)
        {
            _sendMessage = sendMessage;
            _sendMessage.SendMessageEvent += SendMessageEvent;
        }

        private void SendMessageEvent(object sender, MessageEventArgs e)
        {
            Console.WriteLine("SubscriberA received message: " + e.Message);
        }
    }

    public class SubscriberB
    {
        private readonly SendMessage _sendMessage;
        public SubscriberB(SendMessage sendMessage)
        {
            _sendMessage = sendMessage;
            _sendMessage.SendMessageEvent += SendMessageEvent;
        }

        private void SendMessageEvent(object sender, MessageEventArgs e)
        {
            Console.WriteLine("SubscriberB received message: " + e.Message);
        }
    }
}
