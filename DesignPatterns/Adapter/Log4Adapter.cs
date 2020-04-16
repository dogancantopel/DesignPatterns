using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Log4Adapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }
}
