using System;

namespace SumOfArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTerm = 2;
            int lastTerm = 35;
            int commonDifference = 3;

            int numberOfTerms = (lastTerm - firstTerm) / commonDifference + 1;
            int sum = (firstTerm + lastTerm) * numberOfTerms / 2;

            Console.WriteLine("Sum of the arithmetic progression: " + sum);
        }
    }
}
