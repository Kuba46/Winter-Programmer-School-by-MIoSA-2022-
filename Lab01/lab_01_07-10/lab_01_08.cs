using System;

namespace SumOfFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            long sum = 0;
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial;
            }

            Console.WriteLine("Sum of factorials from 1 to " + n + " is: " + sum);
        }
    }
}
