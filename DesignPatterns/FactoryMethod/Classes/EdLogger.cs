using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Ed Logger");
        }
    }
}
