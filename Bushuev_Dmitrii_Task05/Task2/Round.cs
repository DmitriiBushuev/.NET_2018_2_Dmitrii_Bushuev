using System;

namespace Task2
{
    class Round
    {
        public Round (int x, int y, int radius)
        {
            if (radius <= 0)
            {
                throw new InvalidOperationException("Радиус не может быть меньше или равен 0!");
            }

            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public int x, y, radius;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (radius <= 0)
                {
                    throw new InvalidOperationException("Радиус не может быть меньше или равен 0!");
                }
                else
                {
                    Radius = value;
                }
            }
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public override string ToString()
        {
            return $"Координаты круга: {X},{Y}; радиус: {Radius}, площадь: {Area}, длина окружности: {Length}";
        }
    }
}
