using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4Adapter());
            productManager.Save();
            Console.ReadLine();
        }
    }
}
