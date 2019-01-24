using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_2019_classWork
{                        //Inheritance//Interfaces
    public class SMSSender : Object, ISender
    {
        public string message { get; set; }
        public string To { get ; set ; }

        public void Send(string message, string to)
        {
            Console.WriteLine($"SMS text{message}has sent to number{to}");
        }        
    }
}
