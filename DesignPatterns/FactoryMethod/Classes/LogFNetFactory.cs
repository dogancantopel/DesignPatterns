using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Classes
{
    public class LogFNetFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new LogFNetLogger();
        }
    }
}
