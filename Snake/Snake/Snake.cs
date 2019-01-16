using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point snakeTail, int snakeLenght, Direction _direction)
        {
            direction = _direction;

            pList = new List<Point>();
            for (int i = 0; i < snakeLenght; i++)
            {
                Point p = new Point(snakeTail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point snakeTail = pList.First();
            pList.Remove(snakeTail);
            Point head = GetNextPoint();
            pList.Add(head);

            snakeTail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);

            return nextPoint;
        }
    }
}
