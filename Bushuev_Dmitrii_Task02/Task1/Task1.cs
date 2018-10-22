using System;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            int side1, side2, area;
            string errorMessage = "Некорректное значение! Нажмите любую клавишу для выхода";
            Console.WriteLine("Привет! Эта программа поможет найти тебе площадь прямоугольника, введи длину одной из его сторон:");
            if (int.TryParse(Console.ReadLine(), out side1) && side1 > 0)
            {
                Console.WriteLine("Хорошо, теперь вторую сторону:");
                if (int.TryParse(Console.ReadLine(), out side2) && side2 > 0)
                {
                    area = side1 * side2;
                    Console.WriteLine($"Площадь твоего прямоугольника равна {area}, нажми любую клавишу для выхода.");
                    Console.ReadKey();
                    return;
                }

            }
            Console.WriteLine(errorMessage);
            Console.ReadKey();
        }
    }
}
