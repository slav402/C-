using System;

namespace _08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double movieLenght = double.Parse(Console.ReadLine());
            double breack = double.Parse(Console.ReadLine());

            double lunchTime = breack * 1 / 8;
            double restTime = breack * 1 / 4;

            double freeTime = breack - lunchTime - restTime;

            if (freeTime >= movieLenght)
            {
                Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(freeTime - movieLenght)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(movieLenght-freeTime)} more minutes.");
            }
        }
    }
}
