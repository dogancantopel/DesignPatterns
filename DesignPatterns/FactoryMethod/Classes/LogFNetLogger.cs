using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Classes
{
    public class LogFNetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("LogFNet Logger");
        }
    }
}
