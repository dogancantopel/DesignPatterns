using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class LoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Business to decide factory
            return new EdLogger();
        }
    }
}
