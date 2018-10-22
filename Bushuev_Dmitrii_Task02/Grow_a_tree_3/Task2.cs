using System;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давай построим ёлку! Введи количество уровней для неё!(только целое число!)");
            int numberOfLevels;
            if (int.TryParse(Console.ReadLine(), out numberOfLevels))
            {
                if (numberOfLevels > 0)
                {
                    for (int i = 0; i < numberOfLevels + 1; i++)
                    {
                        for (int countOfStars = 0; countOfStars < i; countOfStars++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Меньше одного уровня не получится! Придумай количество уровней больше нуля и возвращайся!");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Не похоже на целое число! Придумай количество уровней и возвращайся!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Неплохо получилось! Нажми любую клавишу для выхода!");
            Console.ReadKey();
        }
    }
}
