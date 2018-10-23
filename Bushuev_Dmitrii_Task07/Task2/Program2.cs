using System;

namespace Task2
{
    class Program2
    {
        static void Main(string[] args)
        {
            GeometricProgression myGeometricProgression = new GeometricProgression(1, 2);
            PrintSeries(myGeometricProgression);
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
    }
}
