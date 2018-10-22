using System;
using System.Text;

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
                        /*StringBuilder strBuild = new StringBuilder();
                        for (int spaces = 0; spaces < numberOfLevels - i - 1; spaces++) 
                        {
                            strBuild.Append(" ");
                        }
                        strBuild.Append("*");
                        for (int countOfStars = 0; countOfStars < i; countOfStars++)
                        {
                            strBuild.Append("**");
                        }
                        string line = strBuild.ToString();*/
                        //Console.WriteLine(line);
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
