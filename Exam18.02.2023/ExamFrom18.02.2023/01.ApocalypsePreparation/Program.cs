using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ApocalypsePreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> textiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            
            Dictionary<string, int> healingItems = new Dictionary<string, int>
            {
                {"Patch", 0 },
                {"Bandage", 0 },
                {"MedKit", 0 }
            };

            while (textiles.Any() && medicaments.Any())
            {
                int textileUnit = textiles.Dequeue();
                int medicamentUnit = medicaments.Pop();

                int resurseSum = textileUnit + medicamentUnit;

                if (resurseSum > 100)
                {
                    resurseSum -= 100;
                    healingItems["MedKit"]++;
                    int nextValue = medicaments.Pop() + resurseSum;
                    medicaments.Push(nextValue);
                }
                else if (resurseSum == 100)
                {
                    healingItems["MedKit"]++;
                }
                else if (resurseSum == 40)
                {
                    healingItems["Bandage"]++;
                }
                else if (resurseSum == 30)
                {
                    healingItems["Patch"]++;
                }
                else
                {
                    medicamentUnit += 10;
                    medicaments.Push(medicamentUnit);
                }
            }

            if (textiles.Count==0 && medicaments.Count == 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
                PrintHealtItems(healingItems);
            }
            else if (medicaments.Count == 0)
            {
                Console.WriteLine("Medicaments are empty.");

                PrintHealtItems(healingItems);

                Console.Write("Textiles left: ");
                Console.WriteLine(String.Join(", ", textiles));
            }
            else
            {
                Console.WriteLine("Textiles are empty.");

                PrintHealtItems(healingItems);

                Console.Write("Medicaments left: ");
                Console.WriteLine(String.Join(", ", medicaments));
            }

        }

        private static void PrintHealtItems(Dictionary<string, int> healingItems)
        {
            var currentDict = healingItems.OrderByDescending(k => k.Value).ThenBy(x => x.Key);

            foreach (var item in currentDict)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
