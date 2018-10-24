using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Regex reg1 = new Regex("\\W+");

            string myText = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled " +
                "and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain" +
                " and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will," +
                " which is the same as saying through shrinking from toil and pain.";

            string[] words = reg1.Split(myText);

            Dictionary<string, int> dict = new Dictionary<string, int>();//создаём словарь где ключ - ключевое слово, значение - количество повторений слова

            foreach (string word in words)//проверяем есть ли слово в словаре
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;//ведём счет повторений
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            string key;
            int value;
            // Сортировка по количеству повторений
            List<KeyValuePair<string, int>> listToSort = new List<KeyValuePair<string, int>>(dict);
            listToSort.Sort((x, y) => y.Value.CompareTo(x.Value));

            Console.WriteLine("Слова в тексте:");
            for (int i = 0; i < listToSort.Count; i++)
            {
                key = listToSort[i].Key;
                value = listToSort[i].Value;
                Console.WriteLine($"{i + 1}: Слово - {key}, количество повторений в тексте - {value}");
            }
            Console.ReadKey();
        }
    }
}
