using System;

namespace SeriesSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            double x = -5;
            double sum = 0;
            double term = 1;

            for (int i = 1; i <= n; i++)
            {
                term *= x / i;
                sum += term;
            }

            Console.WriteLine("Sum of the series: " + sum);
        }
    }
}
