using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> listofTeams = new List<Team>();

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] parts = inputLine.Split(";");

                string command = parts[0];

                switch (command)
                {
                    case "Team":
                        AddTeam(parts[1], listofTeams);
                        break;
                    case "Add":
                        AddPlayer(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), listofTeams);
                        break;
                    case "Remove":
                        RemovePlayer(parts[1], parts[2], listofTeams);
                        break;
                    case "Rating":
                        PrintRating(parts[1], listofTeams);
                        break;
                }
            }
        }

        private static void AddTeam(string name, List<Team> teams)
        {
            try
            {
                teams.Add(new Team(name));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddPlayer(string teamName, string playerName, int endurance, int sprint, int dribble, int passing, int shooting, List<Team> teams)
        {
            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return;
            }

            try
            {
                Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                
                team.AddPlayer(player);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void RemovePlayer(string teamName, string playerName, List<Team> teams)
        {
            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return;
            }

            try
            {
                team.RemovePlayer(playerName);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintRating(string teamName, List<Team> teams)
        {
            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
                return;
            }

            Console.WriteLine($"{teamName} - {team.Rating:f0}");
        }



    }
}
