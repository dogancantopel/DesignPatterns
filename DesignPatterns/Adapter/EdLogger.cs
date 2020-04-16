using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged , {0}", message);
        }
    }
}
