using System;

namespace Task2
{
    class PositiveToZero
    {
        static void Main(string[] args)
        {
            int arraySize1 = 0, arraySize2 = 0, arraySize3 = 0;
            string errorMessage = "Некорректное значение! Нажмите любую клавишу для выхода";
            Console.WriteLine("Привет! Создадим трехмерный массив целых чисел! Введи его размер:");
            if (int.TryParse(Console.ReadLine(), out arraySize1) && arraySize1 > 0 &&
                int.TryParse(Console.ReadLine(), out arraySize2) && arraySize2 > 0 &&
                int.TryParse(Console.ReadLine(), out arraySize3) && arraySize3 > 0 )
            {
                int[,,] myArray = CreatIntArray3(arraySize1, arraySize2, arraySize3);
                MyPositiveToZero(myArray);
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
        public static int[,,] CreatIntArray3(int arraySize1, int arraySize2, int arraySize3)
        {
            int[,,] myArray = new int[arraySize1, arraySize2, arraySize3];
            Random rand = new Random();
            for (int i = 0; i < arraySize1; i++)
            {
                for (int j = 0; j < arraySize2; j++)
                {
                    for (int k = 0; k < arraySize3; k++)
                    {
                        myArray[i,j,k] = rand.Next(-1000, 1000);
                    }
                }
            }
            Console.WriteLine("Элементы массива:");
            foreach (int elementOfArray in myArray)
            {
                Console.WriteLine(elementOfArray);
            }
            return myArray;
        }
        public static void MyPositiveToZero(int[,,] myArray)
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        if (myArray[i, j, k] > 0)
                        {
                            myArray[i, j, k] = 0;
                        }
                    }
                }
            }
            Console.WriteLine("Массив без положительных элементов:");
            foreach (int elementOfArray in myArray)
            {
                Console.WriteLine(elementOfArray);
            }
        }
    }
}
