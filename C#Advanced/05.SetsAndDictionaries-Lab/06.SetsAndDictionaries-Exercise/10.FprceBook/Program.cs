using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.FprceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<string>> userSide = new SortedDictionary<string, SortedSet<string>>();

            string entry = string.Empty;

            while ((entry = Console.ReadLine()) != "Lumpawaroo")
            {
                if (entry.Contains("|"))
                {
                    string[] tokens = entry.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!userSide.Values.Any(n => n.Contains(user)))
                    {
                        if (!userSide.ContainsKey(side))
                        {
                            userSide.Add(side, new SortedSet<string>());
                        }
                        userSide[side].Add(user);
                    }
                }
                else
                {
                    string[] tokens = entry.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string user = tokens[0];
                    string side = tokens[1];

                    foreach (var sides in userSide)
                    {
                        if (sides.Value.Contains(user))
                        {
                            sides.Value.Remove(user);
                        }
                    }
                    
                    if (!userSide.ContainsKey(side))
                    {
                        userSide.Add(side, new SortedSet<string>());
                    }

                    userSide[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            //Dictionary<string, SortedSet<string>> result = userSide.OrderByDescending(u => u.Value.Count).ToDictionary(s => s.Key, u => u.Value);
            var result = userSide.OrderByDescending(u => u.Value.Count);

            foreach (var sides in result)
            {
                if (sides.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {sides.Key}, Members: {sides.Value.Count}");

                    foreach (var item in sides.Value)
                    {
                        Console.WriteLine($"! {item}");
                    }
                }
            }
        }
    }
}
