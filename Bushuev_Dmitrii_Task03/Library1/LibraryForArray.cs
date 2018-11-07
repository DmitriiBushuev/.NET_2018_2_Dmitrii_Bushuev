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
            return;
        }

        public static void PrintOneSideArr(int[] myArray)
        {
            foreach (int elementOfArray in myArray)
            {
                Console.WriteLine(elementOfArray);
            }
        }
    }
}

