using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,25);
            //Console.SetBufferSize(120, 30);

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка точек
            HorizontalLine hLine1 = new HorizontalLine(5, 10, 8, '+');
            hLine1.Draw();

            VerticalLine vLine1 = new VerticalLine(10, 2, 12, '&');
            vLine1.Draw();


            Console.ReadLine();
        }
    }
}
