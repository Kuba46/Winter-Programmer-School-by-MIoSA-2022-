using System;

namespace FunctionTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x\ty(x)");

            for (double x = -4; x <= 4; x += 0.5)
            {
                double y = 0.5 * x * x - 7 * x;
                Console.WriteLine($"{x:F1}\t{y:F2}");
            }
        }
    }
}
