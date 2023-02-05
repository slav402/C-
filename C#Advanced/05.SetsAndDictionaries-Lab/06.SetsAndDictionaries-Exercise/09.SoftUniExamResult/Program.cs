using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SoftUniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> participantsPoints = new SortedDictionary<string, int>();
            SortedDictionary<string, int> submissionsLanguage = new SortedDictionary<string, int>();

            string submission = string.Empty;

            while ((submission = Console.ReadLine()) != "exam finished")
            {
                string[] splitedSubmission = submission.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string user = splitedSubmission[0];

                if (splitedSubmission[1] == "banned")
                {
                    if (participantsPoints.ContainsKey(user))
                    {
                        participantsPoints.Remove(user);
                        continue;
                    }
                }

                string language = splitedSubmission[1];
                int points = int.Parse(splitedSubmission[2]);

                if (!participantsPoints.ContainsKey(user))
                {
                    participantsPoints.Add(user, 0);
                }

                if (participantsPoints[user] < points)
                {
                    participantsPoints[user] = points;
                }

                if (!submissionsLanguage.ContainsKey(language))
                {
                    submissionsLanguage.Add(language, 0);
                }
                submissionsLanguage[language]++;
            }

            var sortedParticipantsPoints = participantsPoints.OrderByDescending(x => x.Value).ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine("Results:");

            foreach (var user in sortedParticipantsPoints)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in submissionsLanguage)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
