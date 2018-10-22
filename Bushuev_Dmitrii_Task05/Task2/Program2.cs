using System;

namespace Task2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Round round1 = new Round(12, 10, 40);
            Console.WriteLine(round1);
            Console.ReadKey();

            try
            {
                Round round2 = new Round(12, 10, 0);
                Console.WriteLine(round1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
