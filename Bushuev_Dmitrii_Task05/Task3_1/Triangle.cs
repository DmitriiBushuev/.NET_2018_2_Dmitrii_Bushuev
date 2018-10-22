using System;

namespace Task3_1
{
    class Triangle
    {
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new InvalidOperationException("Сторона не может быть меньше или равна 0!");
            }

            if ((a > b + c) || (b > a + c) || (c > a + b))
            {
                throw new InvalidOperationException("Одна сторона не может быть больше суммы двух других сторон!");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }
        private double a, b, c;

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Сторона не может быть меньше или равна 0!");
                }
                else if ((value > b + c) || (b > value + c) || (c > value + b))
                {
                    throw new InvalidOperationException("Одна сторона не может быть больше суммы двух других сторон!");
                }
                else
                {
                    a = value;
                }
            }
        }

        public double B
        {
            get
            {
                return b;
            }

            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Сторона не может быть меньше или равна 0!");
                }
                else if ((a > value + c) || (value > a + c) || (c > a + value))
                {
                    throw new InvalidOperationException("Одна сторона не может быть больше суммы двух других сторон!");
                }
                else
                {
                    b = value;
                }
            }
        }

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Сторона не может быть меньше или равна 0!");
                }
                else if ((a > b + value) || (b > a + value) || (value > a + b))
                {
                    throw new InvalidOperationException("Одна сторона не может быть больше суммы двух других сторон!");
                }
                else
                {
                    c = value;
                }
            }
        }

        public double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }

        public double Area
        {
            get
            {
                double halfPerimeter = Perimeter / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            }
        }

        public override string ToString()
        {
            return $"Сторона а = {A}, cторона b = {B}, cторона c = {C}, площадь: {Area}, периметр: {Perimeter}.";
        }
    }
}
