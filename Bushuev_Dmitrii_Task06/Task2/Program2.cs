using System;

namespace Task2
{
    class Program2
    {
        static void Main(string[] args)
        {
            // считаем площадь кольца с координатами 10, 10
            double x1 = 10, y1 = 10;

            Round roundOutter = new Round(x1, y1, 30);// радиус 30
            Console.WriteLine(roundOutter.ToString());
            double outterArea = 0;
            outterArea = roundOutter.Area;
            Console.ReadKey();

            Round roundInner = new Round(x1, y1, 10);//радиус 10
            Console.WriteLine(roundInner.ToString());
            double innerArea = 0;
            innerArea = roundInner.Area;
            Console.ReadKey();

            //площаль кольца
            Console.WriteLine($"Площадь кольца, образуемого двумя кругами: {outterArea - innerArea}");
            Console.ReadKey();
        }
    }
}
