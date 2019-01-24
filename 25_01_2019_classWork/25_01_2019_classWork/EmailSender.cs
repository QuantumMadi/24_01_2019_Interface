using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_2019_classWork
{
    public class EmailSender : ISender, ILogger
    {
        public string message { get ; set ; }
        public string To { get ; set ; }

        void ISender.Send(string message, string to)
        {
            Console.WriteLine($"Email text{message}has sent to number{to}");
        }

        void ILogger.Send(string message, string to)
        {
            throw new NotImplementedException();
        }
        public void Send(string message, string to)
        {
            (this as ISender).Send(message, to);
            (this as ILogger).Send(message, to);
        }
    }
}
