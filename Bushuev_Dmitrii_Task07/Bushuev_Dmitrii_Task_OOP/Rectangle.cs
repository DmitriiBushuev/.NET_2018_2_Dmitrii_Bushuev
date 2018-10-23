using System;

namespace Bushuev_Dmitrii_Task07
{
    class Rectangle : Figure
    {
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1)
        {
            if (x1 == x2 || x1 == x3 || x1 == x4 || x2 == x3 || x2 == x4 || x3 == x4 
                || y1 == y2 || y1 == y3 || y1 == y4 || y2 == y3 || y2 == y4 || y3 == y4)
            {
                throw new InvalidOperationException("Это не четырехугольник!");
            }

            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;


        }
        double lengthSide1 = 0; 
        double lengthSide2 = 0;
        double lengthSide3 = 0;
        double lengthSide4 = 0;


        public double X2
        {
            get; set;
        }

        public double Y2
        {
            get; set;
        }

        public double X3
        {
            get; set;
        }

        public double Y3
        {
            get; set;
        }

        public double X4
        {
            get; set;
        }

        public double Y4
        {
            get; set;
        }

        public override double GetLength()
        {
            lengthSide1 = Math.Sqrt(Math.Pow(Y2 - Y1, 2) + Math.Pow(X2 - X1, 2));
            lengthSide2 = Math.Sqrt(Math.Pow(Y3 - Y2, 2) + Math.Pow(X3 - X2, 2));
            lengthSide3 = Math.Sqrt(Math.Pow(Y4 - Y3, 2) + Math.Pow(X4 - X3, 2));
            lengthSide4 = Math.Sqrt(Math.Pow(Y4 - Y1, 2) + Math.Pow(X4 - X1, 2));
            return lengthSide1 + lengthSide2 + lengthSide3 + lengthSide4;    
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Это четырехугольник, координаты : {X1},{Y1}; {X2},{Y2}; {X3},{Y3}; {X4},{Y4}; периметр: {GetLength()}";
        }
    }
}
