using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_2019_classWork
{
    public interface ISender
    {
        string message { get; set; }
        string To { get; set; }

        void Send(string message, string to);
    }
}
