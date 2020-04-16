using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Name = "Doğancan Topel" };
            Employee employee2 = new Employee() { Name = "Deneme deneme" };
            Employee employee3 = new Employee() { Name = "Deneme1 deneme1" };


            //employee1.AddSubOrdinate(employee1);
            employee1.AddSubOrdinate(employee2);
            employee1.AddSubOrdinate(employee3);

            foreach (Employee manager in employee1)
            {
                Console.WriteLine(manager.Name);
                foreach (Employee employee in manager)
                {
                    Console.WriteLine(employee.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
