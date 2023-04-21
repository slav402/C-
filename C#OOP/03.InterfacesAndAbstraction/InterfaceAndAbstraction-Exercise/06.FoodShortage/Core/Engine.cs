using FoodShortage.Core.Interfacess;
using FoodShortage.Models;
using FoodShortage.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FoodShortage.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> dudes = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string age = tokens[1];

                if (tokens.Length == 4)
                {
                    string id = tokens[2];
                    string birthday = tokens[3];

                    Citizen currentCitizen = new Citizen(name, age, id, birthday);

                    dudes.Add(name, currentCitizen);
                }
                else
                {
                    string group = tokens[2];

                    Rebel currentRebel = new Rebel(name, age, group);

                    dudes.Add(name, currentRebel);
                }
            }

            string buyer;

            while ((buyer = Console.ReadLine()) != "End")
            {
                if (dudes.ContainsKey(buyer))
                {
                    dudes[buyer].BuyFood();
                }
            }

            int sum = 0;

            foreach (var guy in dudes)
            {
                sum += guy.Value.Food;
            }

            Console.WriteLine(sum);
        }
    }
}
