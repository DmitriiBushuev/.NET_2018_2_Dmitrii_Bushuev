using System;
using System.Text.RegularExpressions;

namespace Task06
{
    class NumbCult
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            Regex myRegExScience = new Regex(@"(-?\d\.\d+[eE]-?\d+)");
            Regex myRegExCommon = new Regex(@"-?\d+(\.\d+)?");
            string myNumber = Console.ReadLine();

            if (myRegExScience.IsMatch(myNumber))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else if (myRegExCommon.IsMatch(myNumber))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else
            {
                Console.WriteLine("Это не число.");
            }
            Console.WriteLine("Нажми любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
