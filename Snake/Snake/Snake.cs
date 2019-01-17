using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        ConsoleKey oldKey = ConsoleKey.LeftArrow;

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

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                if (oldKey != ConsoleKey.RightArrow)
                {
                    direction = Direction.LEFT;
                    oldKey = key;
                }
            }
            else if (key == ConsoleKey.RightArrow)
            {
                if (oldKey != ConsoleKey.LeftArrow)
                {
                    direction = Direction.RIGHT;
                    oldKey = key;
                }
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (oldKey != ConsoleKey.UpArrow)
                {
                    direction = Direction.DOWN;
                    oldKey = key;
                }
            }
            else if (key == ConsoleKey.UpArrow)
            {
                if (oldKey != ConsoleKey.DownArrow)
                {
                    direction = Direction.UP;
                    oldKey = key;
                }
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        public bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }
    }
}
