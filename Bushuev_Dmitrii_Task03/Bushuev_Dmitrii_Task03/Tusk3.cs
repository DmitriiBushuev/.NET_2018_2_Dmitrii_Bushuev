using System;
using LibraryForArray;

namespace Tusk3
{
    class SumOfPositive
    {
        static void Main(string[] args)
        {
            int arraySize;
            string errorMessage = "Некорректное значение! Нажмите любую клавишу для выхода";
            Console.WriteLine("Привет! Создадим одномерный массив целых чисел! Введи его размер:");
            if (int.TryParse(Console.ReadLine(), out arraySize) && arraySize > 0)
            {
                int [] myArray = ArrayMethods.CreatIntArray(arraySize);
                SumOfPositiveElements(myArray);
                Console.WriteLine("Нажмие любую клавишу для выхода.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine(errorMessage);
                Console.ReadKey();
                return;
            }
        }
        public static void SumOfPositiveElements(int[] myArray)
        {
            int count = 0;
            foreach (int elementOfArray in myArray)
            {
                if (elementOfArray > 0)
                {
                    count += elementOfArray;
                }
            }
            Console.WriteLine($"Сумма неотрицательных элементов массива: {count}");
        }
    }
}
