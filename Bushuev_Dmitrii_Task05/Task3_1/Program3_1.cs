using System;

namespace Task3_1
{
    class Program3_1
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(12, 10, 5);
            triangle1.A = 12;
            triangle1.B = 10;
            triangle1.C = 15;
            Console.WriteLine(triangle1);
            Console.ReadKey();

            try
            {
                Triangle triangle2 = new Triangle(12, 10, 0);
                Console.WriteLine(triangle2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
