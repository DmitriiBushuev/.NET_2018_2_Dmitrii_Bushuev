using System;
using LibraryForArray;

namespace Task1
{
    class CreatingArray
    {
        static void Main(string[] args)
        {
            int arraySize;
            string errorMessage = "Некорректное значение! Нажмите любую клавишу для выхода";
            Console.WriteLine("Привет! Создадим одномерный массив целых чисел! Введи его размер:");
            if (int.TryParse(Console.ReadLine(), out arraySize) && arraySize > 0)
            {
                int[] myArray = ArrayMethods.CreatIntArray(arraySize);
                ArrayMethods.SortIntArray(myArray);
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
    }
}
