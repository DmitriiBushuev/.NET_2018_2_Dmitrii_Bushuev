using System;

namespace Tusk4
{
    class SumOfEvenElements
    {
        static void Main(string[] args)
        {
            int arraySize1 = 0, arraySize2 = 0;
            string errorMessage = "Некорректное значение! Нажмите любую клавишу для выхода";
            Console.WriteLine("Привет! Создадим двумерный массив целых чисел! Введи его размер:");
            if (int.TryParse(Console.ReadLine(), out arraySize1) && arraySize1 > 0 &&
                int.TryParse(Console.ReadLine(), out arraySize2) && arraySize2 > 0)
            {
                int[,] myArray = CreatIntArray2(arraySize1, arraySize2);
                MySumOfEvenElements(myArray);
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

        private static void MySumOfEvenElements(int[,] myArray)
        {
            int sumEven = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0 && (i > 0 || j > 0))
                    {
                        sumEven += myArray[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма четных элементов: {sumEven}");
        }

        public static int[,] CreatIntArray2(int arraySize1, int arraySize2)
        {
            int[,] myArray = new int[arraySize1, arraySize2];
            Random rand = new Random();
            for (int i = 0; i < arraySize1; i++)
            {
                for (int j = 0; j < arraySize2; j++)
                {
                        myArray[i, j] = rand.Next(-1000, 1000);
                }
            }
            Console.WriteLine("Элементы массива:");
            foreach (int elementOfArray in myArray)
            {
                Console.WriteLine(elementOfArray);
            }
            return myArray;
        }
    }
}
