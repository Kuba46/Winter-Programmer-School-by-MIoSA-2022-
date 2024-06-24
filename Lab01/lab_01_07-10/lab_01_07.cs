using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial of " + n + " is: " + factorial);
        }
    }
}
