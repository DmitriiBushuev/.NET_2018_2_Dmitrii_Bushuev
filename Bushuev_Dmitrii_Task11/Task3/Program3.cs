using System;
using System.Collections.Generic;

namespace Task3
{
    class Program3
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash newPoint1 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash newPoint2 = new TwoDPointWithHash(10, 10);

            Console.WriteLine($"Hash for point1: {newPoint1.GetHashCode()}\tHash for point2: {newPoint2.GetHashCode()}" );

            // проверка совпадений хэш кодов
            int countHashRe = 0;
            Dictionary<int, Tuple<int, int>> dict = new Dictionary<int, Tuple<int, int>>();
            for (int i = 0; i < 2000; i++)
            {
                for (int j = 0; j < 2000; j++)
                {
                    TwoDPointWithHash point = new TwoDPointWithHash(i, j);
                    int hash = point.GetHashCode();
                    if(dict.ContainsKey(hash))
                    {
                        //Console.WriteLine($"Hash exists by {dict[hash].Item1}:{dict[hash].Item2}, current point {i}:{j}");
                        countHashRe++;
                    }
                    else
                    {
                        dict.Add(hash, new Tuple<int, int>(i, j));
                    }
                }
            }

            Console.WriteLine($"Совпадений: {countHashRe}");
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
