using System;

namespace _.NET_2018_2_Task_1_Bushuev_Dmitrii_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Давай построим ёлку! Введи количество ярусов для неё!(только целое число!)");
            int NumberOfLevels;
            if (int.TryParse(Console.ReadLine(), out NumberOfLevels))
            {
                for (int i = 0; i < NumberOfLevels; i++)
                {
                    Console.WriteLine("  *  ");
                    Console.WriteLine(" *** ");
                    Console.WriteLine("*****");
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
    }
}
