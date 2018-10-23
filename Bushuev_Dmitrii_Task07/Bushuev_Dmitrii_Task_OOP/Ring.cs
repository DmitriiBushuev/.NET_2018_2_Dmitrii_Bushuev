using System;

namespace Bushuev_Dmitrii_Task07
{
    internal class Ring : Round
    {
        public Ring(double x1, double y1, double radius, double internalRadius)
                : base(x1, y1, radius)
        {
            if (internalRadius <= 0 || internalRadius > radius)
            {
                throw new InvalidOperationException(" Внутренний радиус не может быть меньше или равен 0 или быть больше внешнего!");
            }

            this.internalRadius = internalRadius;

        }
        double internalRadius = 0;

        public double InternalRadius
        {
            get
            {
                return internalRadius;
            }
            set
            {
                if (internalRadius <= 0 || internalRadius > Radius)
                {
                    throw new InvalidOperationException(" Внутренний радиус не может быть меньше или равен 0 или быть больше внешнего!");
                }
                internalRadius = value;
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * (Math.Pow(Radius, 2) - Math.Pow(InternalRadius, 2));
            }
        }

        public double LengthOfTwoCircles
        {
            get
            {
                return (2 * Math.PI * Radius) + (2 * Math.PI * InternalRadius);
            }
        }

        public override double GetLength()
        {
            return LengthOfTwoCircles;
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Это кольцо, координаты центра кольца: {X1},{Y1}, внутренний радиус: {InternalRadius}," +
                $"внешний радиус {Radius}, суммарная длина внешнего и внутреннего кольца: {LengthOfTwoCircles}, площадь кольца: {Area}. ";
        }
    }
}