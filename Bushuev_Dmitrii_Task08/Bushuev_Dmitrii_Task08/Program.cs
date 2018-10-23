using System;

namespace Bushuev_Dmitrii_Task08
{
    partial class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> myDynamicArray1 = new DynamicArray<int>();

            DynamicArray<int> myDynamicArray2 = new DynamicArray<int>(10);

            int[] newArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DynamicArray<int> myDynamicArray3 = new DynamicArray<int>(newArray);

            myDynamicArray3.Add(99);

            myDynamicArray3.AddRange(newArray);

            myDynamicArray3.Remove(10);

            myDynamicArray3.Insert(999, 10);

            Console.WriteLine(myDynamicArray3.Length);
            Console.WriteLine(myDynamicArray3.Capacity);

            Console.WriteLine(myDynamicArray3[10]);

            Console.ReadKey();
        }

        static void PrintSeries<T>(ISeries<T> series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
