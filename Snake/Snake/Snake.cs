using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point snakeTail, int snakeLenght, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < snakeLenght; i++)
            {
                Point p = new Point(snakeTail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
