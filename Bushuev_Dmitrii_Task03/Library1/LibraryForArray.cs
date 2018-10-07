using System;

namespace LibraryForArray
{
    public class ArrayMethods
    {
        public static int[] CreatIntArray(int arraySize)
        {
            int[] myArray = new int[arraySize];
            Random rand = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                myArray[i] = rand.Next(-1000, 1000);
            }
            Console.WriteLine("Элементы массива:");
            foreach (int elementOfArray in myArray)
            {
                Console.WriteLine(elementOfArray);
            }
            return myArray;
        }
        public static void SortIntArray(int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                    if (myArray[i] > myArray[j])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
            }
            Console.WriteLine("Отсортированные элементы массива:");
            foreach (int elementOfArray in myArray)
            {
                Console.WriteLine(elementOfArray);
            }
            Console.WriteLine($"Наименьший элемент массива:{myArray[0]}");
            Console.WriteLine($"Наибольший элемент массива: {myArray[myArray.Length - 1]}");
            return;
        }
    }
}

