using System;

namespace Ameba
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialCells = 10;
            int divisionTime = 3;
            int totalTime = 24;

            for (int i = 0; i <= totalTime; i += divisionTime)
            {
                int cells = initialCells * (int)Math.Pow(2, i / divisionTime);
                Console.WriteLine("Number of cells after " + i + " hours is: " + cells);
            }
        }
    }
}
