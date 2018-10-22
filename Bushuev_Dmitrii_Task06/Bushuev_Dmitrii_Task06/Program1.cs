using System;

namespace Bushuev_Dmitrii_Task06
{
    class Program1
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee(new DateTime(1990, 12, 5), "Ivan", "Ivanovich", "Ivanov", new DateTime(2012, 12, 5), "Шеф");
            Console.WriteLine(Employee1.ToString());
            Console.ReadKey();

            try
            {
                User Employee2 = new Employee(new DateTime(2000, 09, 4), "Ivan", "Ivanovich", "Ivanov", new DateTime(2014, 09, 3), "Шеф");
                Console.WriteLine(Employee2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
