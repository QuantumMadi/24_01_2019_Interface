using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_2019_classWork
{
    public static class ServiceLocator
    {
        public static ISender Sender
        {
            get
            {
                return new SMSSender();
            }
        }
        public static ILogger Logger
        {
            get
            {
                return new EmailSender();
            }
        }
    }
}
