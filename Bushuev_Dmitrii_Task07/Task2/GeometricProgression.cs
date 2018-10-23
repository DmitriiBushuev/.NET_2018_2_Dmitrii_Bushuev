using System;

namespace Task2
{
    public class GeometricProgression : ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricProgression(double start, double step)
        {
            if (start == 0 || step == 0)
            {
                throw new InvalidOperationException("Некорректное значение");
            }

            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start * Math.Pow(step, currentIndex - 1);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
