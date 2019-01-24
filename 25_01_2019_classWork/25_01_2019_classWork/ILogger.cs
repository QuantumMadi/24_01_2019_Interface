using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_01_2019_classWork
{
    public interface ILogger
    {
        void Send(string message, string to);
    }
}
