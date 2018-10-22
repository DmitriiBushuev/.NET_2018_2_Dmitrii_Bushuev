using System;

namespace Task2
{
    class Round
    {
        public Round(double x, double y, double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidOperationException("Радиус не может быть меньше или равен 0!");
            }

            this.x = x;
            this.y = y;
            this.radius = radius;

        }
        double x, y, radius;

        // public double X {get; set;}
        public double X
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

        public double Y
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

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Радиус не может быть меньше или равен 0!");
                }
                radius = value;
            }
        }

        public double Length
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public virtual double Area
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
