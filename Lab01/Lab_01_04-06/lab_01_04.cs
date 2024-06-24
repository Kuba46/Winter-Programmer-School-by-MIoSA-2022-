using System;

namespace CosineSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= 9; i++)
            {
                double term = Math.Cos(i * x) / Math.Pow(x, i - 1);
                sum += term;
            }

            Console.WriteLine("Sum of the series: " + sum);
        }
    }
}
