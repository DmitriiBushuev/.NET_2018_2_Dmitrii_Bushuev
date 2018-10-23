

namespace Bushuev_Dmitrii_Task07
{
    abstract class Figure
    {
        public bool IsValid()
        {
            var Lenght = GetLength();
            return Lenght > 10;
        }
        public Figure(double x1, double y1)
        {
            X1 = x1;
            Y1 = y1;
        }

        public double X1
        {
            get ; set;
        }

        public double Y1
        {
            get; set;
        }

        public abstract double GetLength();
        public abstract void Draw();
    }
}
