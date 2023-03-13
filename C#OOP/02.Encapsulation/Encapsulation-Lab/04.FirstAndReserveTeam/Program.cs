using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            List<Person> personsList = new List<Person>();
            Team team = new Team("SoftUni");

            for (int i = 0; i < inputLines; i++)
            {
                var entry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person curentPerson = new Person(entry[0], entry[1], int.Parse(entry[2]), decimal.Parse(entry[3]));

                personsList.Add(curentPerson);
            }

            foreach (Person person in personsList)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
