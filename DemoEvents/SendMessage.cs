using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvents
{
    public class MessageEventArgs: EventArgs
    {
        public string Message { get; set; }
    }
    public class SendMessage
    {
        //public delegate void SendMessageEventHandler(object sender, SendMessageEventArgs e);
        public event EventHandler<MessageEventArgs> SendMessageEvent;

        public void OnSendMessageEvent(string message)
        {
            MessageEventArgs messageEventArgs = new MessageEventArgs();
            messageEventArgs.Message = message;

            if(SendMessageEvent != null)
            SendMessageEvent(this, messageEventArgs);
        }
    }
}
