using ExplicitInterfaces.Core.Interfaces;
using ExplicitInterfaces.Models;
using ExplicitInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<Citizen> citizens = new List<Citizen>();

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "End") 
            {
                string[] token = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = token[0];
                string country = token[1];
                int age = int.Parse(token[2]);

                Citizen citizen = new Citizen(name, country, age);

                citizens.Add(citizen);
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
