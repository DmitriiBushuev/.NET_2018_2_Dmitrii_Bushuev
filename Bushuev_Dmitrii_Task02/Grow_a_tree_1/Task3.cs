using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давай построим ёлку! Введи количество уровней для неё!(только целое число!)");
            string errorMessage = "Некорректное значение! Нажмите любую клавишу для выхода";
            int numberOfLevels;
            if (int.TryParse(Console.ReadLine(), out numberOfLevels))
            {
                if (numberOfLevels > 0)
                {
                    for (int i = 0; i < numberOfLevels; i++)
                    {
                        string spaces = new string(' ', numberOfLevels - i - 1);
                        string stars = new string('*', i * 2);
                        Console.WriteLine(spaces + '*' + stars);
                    }
                    Console.WriteLine("Неплохо получилось! Нажми любую клавишу для выхода!");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine(errorMessage);
            Console.ReadKey();
        }
    }
}
