using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager();
            cm.Save();
            Console.ReadLine();
        }
    }
}
