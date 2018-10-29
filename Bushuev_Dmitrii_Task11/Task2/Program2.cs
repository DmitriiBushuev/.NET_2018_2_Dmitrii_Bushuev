using System;

namespace Task2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(new DateTime(1980, 12, 18), "Don", "Don", "Don", new DateTime(2000, 12, 18),"Шеф");
            Employee employee2 = new Employee(new DateTime(1980, 12, 18), "Don", "Don", "Don", new DateTime(2000, 12, 18),"Сеньор");

            Console.WriteLine(employee1.Equals(employee2));

            Console.WriteLine(employee1.GetHashCode());
            Console.WriteLine(employee2.GetHashCode());
            Console.ReadKey();
        }   
    }
}
