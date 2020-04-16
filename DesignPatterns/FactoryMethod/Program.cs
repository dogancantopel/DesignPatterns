using FactoryMethod.Classes;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burası normalde IOC Containerlar ile ayağa kaldırılıyor.
            CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            customerManager.Save();
            CustomerManager customerManager1 = new CustomerManager(new LogFNetFactory());
            customerManager1.Save();
            Console.ReadLine();
        }
    }
}
