using System;
using System.Diagnostics;
using System.Text;


namespace Task4
{
    class RunStringBuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Проверим быстродействие цикла for и StringBuilder на 100000 итераций, нажми клавишу для старта!");
            Console.ReadKey();
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100000;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopwatch.Stop();
            Console.WriteLine($"Время цикла: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopwatch.Stop();
            Console.WriteLine($"Время StringBuilder: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine("Нажми любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
