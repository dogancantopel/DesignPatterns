using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Caching:ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }
}
