using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_2019_classWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ISender sender = ServiceLocator.Sender;
            sender.Send("Text", "admin@admin.admin");
        }
    }
}
