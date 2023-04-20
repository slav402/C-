using BorederControl.Core.Interface;
using BorederControl.Models;
using BorederControl.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorederControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IIdentifiable> identifiable = new List<IIdentifiable>();

            string enterLine = string.Empty;

            while ((enterLine = Console.ReadLine()) != "End")
            {
                string[] tokens = enterLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    string model = tokens[0];
                    string id = tokens[1];
                    
                    Robot currentRobot = new Robot(model, id);
                    
                    identifiable.Add(currentRobot);
                }
                else
                {
                    string name = tokens[0];
                    string age = tokens[1];
                    string id = tokens[2];
                    
                    Citizen currentCitizen = new Citizen(name, age, id);
                    
                    identifiable.Add(currentCitizen);
                }
            }

            string lastDigits = Console.ReadLine();

            foreach (var person in identifiable)
            {
                if (person.Id.EndsWith(lastDigits))
                 {
                    Console.WriteLine(person.Id);
                }
            }
        }
    }
}
