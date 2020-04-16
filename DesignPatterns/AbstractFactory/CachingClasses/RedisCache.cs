using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.CachingClasses
{
    public class RedisCache:Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Caching with redis");
        }
    }
}
