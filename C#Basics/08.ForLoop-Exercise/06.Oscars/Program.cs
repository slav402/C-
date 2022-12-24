using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int assessorCount = int.Parse(Console.ReadLine());
            double neededPoints = 1250.5;

            for (int i = 0; i < assessorCount; i++)
            {
                string jury = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                points += (jury.Length * rating) / 2;

                if (points > neededPoints)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            if (points <= neededPoints)
            {
                Console.WriteLine($"Sorry, {name} you need {(neededPoints-points):f1} more!");
            }
        }
    }
}
