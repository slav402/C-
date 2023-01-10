using System;

namespace _01.ConvertMetersToKilometers
{
    class ConvertMetersToKilometers
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0M;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
