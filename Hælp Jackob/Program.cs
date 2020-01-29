using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hælp_Jackob
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageHandler handler = new MessageHandler();
            Message m = new Message("Jon", "Ben", "I miss you", "Stuff", "non");
            string[] to =
            {
                "Rene",
                "Benjamin"
            };
            handler.HandleMessage(m, true, MessageCarrier.Smtp);
            handler.HandleMessage(m, to, true, MessageCarrier.Smtp);
            Console.ReadKey();
        }
        
    }
}
