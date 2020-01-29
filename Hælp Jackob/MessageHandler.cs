using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hælp_Jackob
{
    class MessageHandler
    {
        MessageSender sender;
        public void HandleMessage(Message m, bool isHtml, MessageCarrier carrier)
        {
            if (isHtml)
                m.Body = HTMLConvert.ConvertBodyToHTML(m.Body);

            HandleCarrier(carrier);
            sender.sendMessage(m);
        }

        public void HandleMessage(Message m, string[] to, bool isHtml, MessageCarrier carrier)
        {
            if (isHtml)
                m.Body = HTMLConvert.ConvertBodyToHTML(m.Body);

            HandleCarrier(carrier);
            foreach (string person in to)
            {
                m.To = person;
                sender.sendMessage(m);
            }
        }

        void HandleCarrier (MessageCarrier carrier)
        {
            switch (carrier)
            {
                case MessageCarrier.Smtp:
                    sender = new SendMessageSMTP();
                    break;
                case MessageCarrier.VMessage:
                    sender = new SendMessageVmessage();
                    break;
                default:
                    break;
            }
        }

    }
}
