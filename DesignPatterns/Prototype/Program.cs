using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                Name = "Doğancan",
                LastName = "Topel",
                City = "İstanbul",
                CustomerId = 54,
                Id = 1
            };
            //Newleme maliyeti olmadan farklı bir referans oluşmuş oldu. İkisi Aynı nesne değil.
            var customer2 = customer.Clone();
            customer2.Name = "Deneme";
            Console.WriteLine(customer2.Name);
            Console.WriteLine(customer.Name);
            Console.ReadLine();
        }
    }
}
