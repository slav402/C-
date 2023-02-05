using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> candidatesList = new SortedDictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> contestPasses = new Dictionary<string, string>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] splitingCommand = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = splitingCommand[0];
                string password = splitingCommand[1];

                contestPasses.Add(contest, password);
            }

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] splitingCommand = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = splitingCommand[0];
                string password = splitingCommand[1];
                string user = splitingCommand[2];
                int points = int.Parse(splitingCommand[3]);

                if (contestPasses.ContainsKey(contest) && contestPasses[contest] == password)
                {
                    if (!candidatesList.ContainsKey(user))
                    {
                        candidatesList.Add(user, new Dictionary<string, int>());
                    }

                    if (!candidatesList[user].ContainsKey(contest))
                    {
                        candidatesList[user].Add(contest, 0);
                    }

                    if (candidatesList[user][contest] < points)
                    {
                        candidatesList[user][contest] = points;
                    }
                }
            }

            string[] bestUser = GetBestUser(candidatesList);

            Console.WriteLine($"Best candidate is {bestUser[0]} with total {bestUser[1]} points.");
            Console.WriteLine("Ranking:");

            //var OrderedCandidatesLisst = candidatesList.OrderBy(x => x.Key);

            foreach (var candidate in candidatesList)
            {
                Console.WriteLine($"{candidate.Key}");

                foreach (var contest in candidate.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

        }

        private static string[] GetBestUser(SortedDictionary<string, Dictionary<string, int>> candidatesLisst)
        {
            string[] bestUser = new string[] {"", ""};
            int bestResult = 0;

            foreach (var user in candidatesLisst)
            {
                int currentResult = 0;

                foreach (var item in user.Value)
                {
                    currentResult += item.Value;
                }

                if (currentResult > bestResult)
                {
                    bestResult = currentResult;
                    bestUser[0] = user.Key;
                    bestUser[1] = bestResult.ToString();
                }
            }

            return bestUser;
        }
    }
}
