using System;

namespace Bushuev_Dmitrii_Task07
{
    class Round : Figure
    {
        public Round(double x1, double y1, double radius) : base (x1, y1)
        {
            if (radius <= 0)
            {
                throw new InvalidOperationException("Радиус не может быть меньше или равен 0!");
            }

            Radius = radius;

        }

        public double Radius
        {
            get; set;
        }

        public override double GetLength()
        {
            return 2 * Math.PI * Radius;
        }

        public virtual double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public override void Draw()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Это круг, координаты центра: {X1},{Y1}; радиус: {Radius}, площадь: {Area}, длина окружности: {GetLength()}";
        }
    }
}
