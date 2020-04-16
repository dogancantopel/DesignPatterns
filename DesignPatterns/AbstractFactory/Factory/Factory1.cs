using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Abstract;
using AbstractFactory.CachingClasses;
using AbstractFactory.LoggingClasses;

namespace AbstractFactory.Factory
{
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
    }
}
