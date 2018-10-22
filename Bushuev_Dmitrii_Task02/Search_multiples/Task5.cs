using System;

namespace Task5
{
    class Task5
    {
        static void Main(string[] args)
        {
            string errorMessage = "Некорректное значение! Нажмите любую клавишу для выхода";
            int number, sum = 0;
            Console.WriteLine("Введите число, программа подсчитает сумму всех натуральных чисел кратных 3 или 5 меньше указанного:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number > 0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            try
                            {
                                checked
                                {
                                    sum += i;
                                }
                            }
                            catch (OverflowException)
                            {
                       
                                Console.WriteLine("Выход за пределы int ! Нажмите любую клавишу для выхода.");
                                Console.ReadKey();
                                return;
                            }
                        }
                    }
                    Console.WriteLine($"Сумма чисел кратных 3 или 5 меньше {number} равна {sum}, нажмите любую клавишу для выхода.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine(errorMessage);
            Console.ReadKey();
        }
    }
}
