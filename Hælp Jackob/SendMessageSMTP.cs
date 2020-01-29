using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hælp_Jackob
{
    class SendMessageSMTP : MessageSender
    {
        public override void sendMessage(Message m)
        {
            Console.WriteLine("Message is send with SMTP");
        }
    }
}
