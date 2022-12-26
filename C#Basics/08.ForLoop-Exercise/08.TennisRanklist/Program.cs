using System;

namespace _08.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int startPoints = points;
            int countsOfWins = 0;

            for (int i = 0; i < n; i++)
            {
                string tournamentResult = Console.ReadLine();

                switch (tournamentResult)
                {
                    case "W": points += 2000;
                              countsOfWins++;
                        break;

                    case "F": points += 1200; 
                        break;

                    case "SF": points += 720; 
                        break;
                    
                    default: break;
                }
            }

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {(points - startPoints)/n}");
            Console.WriteLine($"{((double)countsOfWins / (double)n * 100):f2}%");
        }
    }
}
