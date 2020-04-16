using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
        
    }
}
