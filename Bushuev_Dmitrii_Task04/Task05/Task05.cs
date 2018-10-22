using System;
using System.Text.RegularExpressions;

namespace Task05
{
    class Tags
    {
        static void Main(string[] args)
        {
            Regex myRegEx = new Regex("<[^>]+>");
            Console.WriteLine("Введите текст с html тегами, заменим их на _:");
            string myString = Console.ReadLine();

            string myChangedString = myRegEx.Replace(myString, "_");
            Console.WriteLine(myChangedString);
            Console.WriteLine("Нажми любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
