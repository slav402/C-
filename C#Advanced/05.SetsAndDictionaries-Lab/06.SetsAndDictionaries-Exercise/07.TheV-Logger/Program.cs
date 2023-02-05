using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> listVloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string comandInput = string.Empty;

            while ((comandInput = Console.ReadLine()) != "Statistics")
            {
                string[] splitedInput = comandInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string vlogger = splitedInput[0];
                string command = splitedInput[1];

                if (command == "joined" && !listVloggers.ContainsKey(vlogger))
                {
                    listVloggers.Add(vlogger, new Dictionary<string, SortedSet<string>>());

                    listVloggers[vlogger].Add("followers", new SortedSet<string>());
                    listVloggers[vlogger].Add("following", new SortedSet<string>());

                }
                else
                {
                    string vloggerTwo = splitedInput[2];

                    if (vlogger != vloggerTwo && listVloggers.ContainsKey(vlogger) && listVloggers.ContainsKey(vloggerTwo))
                    {
                        listVloggers[vlogger]["following"].Add(vloggerTwo);
                        listVloggers[vloggerTwo]["followers"].Add(vlogger);
                    }
                }
            }

            Dictionary<string, Dictionary<string, SortedSet<string>>> sortedListVloggers = listVloggers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"The V-Logger has a total of {sortedListVloggers.Count} vloggers in its logs.");
            int counter = 0;

            foreach (var vlogger in sortedListVloggers)
            {
                Console.WriteLine($"{++counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (counter == 1)
                {
                    foreach (var follower in vlogger.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }

        }
    }
}
