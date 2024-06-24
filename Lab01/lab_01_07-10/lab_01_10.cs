using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 3;
            int exponent = 7;
            long result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNumber;
            }

            Console.WriteLine(baseNumber + " to the power of " + exponent + " is: " + result);
        }
    }
}
