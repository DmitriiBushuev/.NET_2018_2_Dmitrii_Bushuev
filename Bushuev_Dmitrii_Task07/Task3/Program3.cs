using System;

namespace Task3
{
    partial class Program3
    {
        static void Main(string[] args)
        {
            ArithmeticalProgression myArithmeticalProgression1 = new ArithmeticalProgression(1, 2);
            PrintSeries(myArithmeticalProgression1);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Элемент №5 : ");
            Console.WriteLine(GetElement(myArithmeticalProgression1, 5));
            Console.ReadKey();

            double[] myArray = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List myList1 = new List(myArray);
            PrintSeries(myList1);
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Элемент №5 : ");
            Console.WriteLine(GetElement(myList1, 5));
            Console.ReadKey();
        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        static double GetElement(IIndexable myIndex, int index)
        {
            return myIndex[index];
        }
    }
}
