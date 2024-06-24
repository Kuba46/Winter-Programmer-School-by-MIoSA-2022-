using System;

namespace SumOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first term (p): ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter common difference (h): ");
            int h = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int term = p + i * h;
                sum += term * term;
            }

            Console.WriteLine("Sum of squares: " + sum);
        }
    }
}
