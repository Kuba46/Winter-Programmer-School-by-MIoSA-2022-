using System;

namespace SumOfSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine("Sum of the series: " + sum);
        }
    }
}
