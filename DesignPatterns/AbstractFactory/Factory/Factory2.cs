using AbstractFactory.Abstract;
using AbstractFactory.CachingClasses;
using AbstractFactory.LoggingClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class Factory2:CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new MemCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();
        }
    }
}
