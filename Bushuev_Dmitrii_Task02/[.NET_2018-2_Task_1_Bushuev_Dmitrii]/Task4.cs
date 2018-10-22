using System;
using System.Text;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давай построим ёлку! Введи количество ярусов для неё!(только целое число!)");
            int numberOfLevels;
            if (int.TryParse(Console.ReadLine(), out numberOfLevels))
            {
                if (numberOfLevels > 0)
                {
                    for (int i = 0; i <= numberOfLevels; i++)
                    {
                        SectorBuilder(i, numberOfLevels);
                    }
                }
                else
                {
                    Console.WriteLine("Меньше одного яруса не получится! Придумай количество ярусов больше нуля и возвращайся!");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Не похоже на целое число! Придумай количество ярусов и возвращайся!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Неплохо получилось! Нажми любую клавишу для выхода!");
            Console.ReadKey();
        }
        private static void SectorBuilder(int numberOfLevels, int numberOfSpaces)
        {
            for (int i = 0; i < numberOfLevels; i++)
            {
                string spaces = new string(' ', numberOfSpaces - i - 1);
                string stars = new string('*', i * 2);
                Console.WriteLine(spaces + '*' + stars);
            }
        }
    }
}
