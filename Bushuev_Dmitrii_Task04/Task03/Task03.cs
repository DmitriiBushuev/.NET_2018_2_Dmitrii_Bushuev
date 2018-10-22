using System;
using System.Globalization;

namespace Task03
{
    class RuEnInvariant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Сравним культуры языка ru en invariant");

            Console.WriteLine("ru vs en");
            Show("ru", "en");

            Console.WriteLine("en vs invariant");
            Show("en", "");

            Console.WriteLine("ru vs invariant");
            Show("ru", "");

            Console.WriteLine("Нажми любую клавишу для выхода.");
            Console.ReadKey();
        }
        public static void Show (string culture1, string culture2)
        {
            double number = 1251235353.57;
            Console.Write(DateTime.Now.ToString(CultureInfo.GetCultureInfo(culture1)) + "\t  | \t");
            Console.WriteLine(DateTime.Now.ToString(CultureInfo.GetCultureInfo(culture2)));
            Console.Write(number.ToString(CultureInfo.GetCultureInfo(culture1)) + "\t\t  | \t");
            Console.WriteLine(number.ToString(CultureInfo.GetCultureInfo(culture2)));
            Console.WriteLine();
        }
    }
}
