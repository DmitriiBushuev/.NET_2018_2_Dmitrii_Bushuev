using System;
using System.Collections.Generic;

namespace Task01
{
    class Double
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Введи строку со словами, посчитаем их среднюю длину");
            
            string myString = Console.ReadLine();
            myString = RemovePunctuationMarks(myString);

            string[] words = myString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double averageLength = Average(words);

            Console.WriteLine(averageLength);
            Console.WriteLine("Нажми любую клавишу для выхода.");
            Console.ReadKey();
        }
        public static string RemovePunctuationMarks(string str)
        {
            List<char> myCharStr = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsPunctuation(str[i]))
                {
                    myCharStr.Add(str[i]);
                }
            }
            return new string(myCharStr.ToArray());
        }
        public static double Average (string[] words)
        {
            double count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                count += words[i].Length;
            }
            return count / words.Length;
        }
    }
}
