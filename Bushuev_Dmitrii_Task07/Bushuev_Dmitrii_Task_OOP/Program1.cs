using System;
using System.Collections.Generic;

namespace Bushuev_Dmitrii_Task07
{
    class Program1
    {
        static void Main(string[] args)
        {
            List<Figure> myFigureArray = new List<Figure>();

            myFigureArray.Add(new Line(10, 20, 30, 40));
            myFigureArray.Add(new Circle(10, 20, 30));
            myFigureArray.Add(new Rectangle(1, 1, 2, 10, 10, 17, 15, 100));
            myFigureArray.Add(new Round(10, 10, 10));
            myFigureArray.Add(new Ring(10, 10, 10, 5));

            foreach (Figure figure in myFigureArray)
            {
                figure.Draw();
            }

            Console.ReadKey();
        }
    }
}
