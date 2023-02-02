using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = entry[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < entry.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(entry[j]))
                    {
                        wardrobe[color].Add(entry[j], 0);
                    }

                    wardrobe[color][entry[j]]++;
                }
            }

            string[] searchComand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string neededColor = searchComand[0];
            string neededClothe = searchComand[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloath in color.Value)
                {
                    Console.Write($"* {cloath.Key} - {cloath.Value}");

                    if (color.Key == neededColor && cloath.Key == neededClothe)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
