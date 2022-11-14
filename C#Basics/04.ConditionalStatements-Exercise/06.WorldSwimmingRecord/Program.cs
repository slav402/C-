using System;

namespace _07.WorlSwimingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentREC = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double swimmingTime = distance * secondsPerMeter;
            double delay = Math.Floor(distance / 15) * 12.5;

            double result = swimmingTime + delay;

            if (result < currentREC)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {result:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(result - currentREC):F2} seconds slower.");
            }
        }
    }
}
