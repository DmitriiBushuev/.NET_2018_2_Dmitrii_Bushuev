using System;

namespace Bushuev_Dmitrii_Task07
{
    class Line : Figure
    {
        public Line(double x1, double y1, double x2, double y2) : base (x1, y1)
        {
            if (x1 == x2 && y1 == y2)
            {
                throw new InvalidOperationException("Получится точка!");
            }

            X2 = x2;
            Y2 = y2;

        }

        public double X2
        {
            get; set;
        }

        public double Y2
        {
            get; set;
        }

        public override double GetLength()
        {
                return Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2));
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Это линия, координаты линии: {X1},{Y1}  {X2},{Y2} , длина линии: {GetLength()}";
        }
    }
}

