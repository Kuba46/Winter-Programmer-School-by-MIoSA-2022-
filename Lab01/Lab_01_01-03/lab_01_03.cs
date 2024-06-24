using System;

namespace SumOfSeries2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int numerator = 2;
            int denominator = 3;
            int maxDenominator = 113;

            while (denominator <= maxDenominator)
            {
                sum += (double)numerator / denominator;
                numerator += 2;
                denominator += 2;
            }

            Console.WriteLine("Sum of the series: " + sum);
        }
    }
}
