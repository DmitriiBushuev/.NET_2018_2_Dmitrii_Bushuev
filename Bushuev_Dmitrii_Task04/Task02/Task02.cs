using System;
using System.Collections.Generic;

namespace Task02
{
    class DoubleChars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Введи строку:");
            string myString1 = Console.ReadLine();
            Console.WriteLine("Введи символы, которые хочешь удвоить в первой строке:");
            string myString2 = Console.ReadLine();

            HashSet<char> charsToDouble = new HashSet<char>(myString2);
            foreach (char symbol in charsToDouble)
            {
                myString1 = myString1.Replace(symbol.ToString(), new string(symbol, 2));
            }
            Console.WriteLine(myString1);
            Console.WriteLine("Нажми любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
