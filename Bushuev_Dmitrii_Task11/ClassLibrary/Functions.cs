using System;

namespace MathLibrary
{
    public class Functions
    {
        public static int Factorial(int number)
        {
            if(number < 0)
                throw new InvalidOperationException("Факториал только для положительных чисел!");

            if (number == 0)
                return 1;

            //return n * Factorial(n - 1);

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        public static double UpPower(double number, double power)
        {
            if (number == 0)
                return 0;

            if (power == 0)
                return 1;

            double result = 1;

            if (power < 0)
            {
                for (int i = 0; i > power; i--)
                {
                    result *= number;
                }
                return 1/result;
            }

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

    }
}
