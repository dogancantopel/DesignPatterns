using AbstractFactory.Factory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var productManager = new ProductManager(new Factory2());
            productManager.GetAll();
            var productManager1 = new ProductManager(new Factory1());
            productManager1.GetAll();
            Console.ReadLine();
        }
    }
}
