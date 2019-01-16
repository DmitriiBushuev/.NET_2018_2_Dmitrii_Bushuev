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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(7, 2,'&');
            p3.Draw();

            HorizontalLine hLine1 = new HorizontalLine(5, 10, 8, '+');
            hLine1.Draw();

            VerticalLine vLine1 = new VerticalLine(12, 2, 10, '&');
            vLine1.Draw();


            Console.ReadLine();
        }
    }
}
