using System;

namespace Bushuev_Dmitrii_Task11
{
    class Program1
    {
        static void Main(string[] args)
        {
            var result1 = MathLibrary.Functions.Factorial(6);
            Console.WriteLine($"Факториал 6 равен {result1}");

            var result2 = MathLibrary.Functions.UpPower(8, -3);
            Console.WriteLine($"8 в степени -3 равно {result2}");

            Console.ReadKey();

        }
    }
}
