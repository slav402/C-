using BorederControl.Core.interfacess;
using BorederControl.Models;
using BorederControl.Models.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorederControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IBirthdayable> birthdayGuys = new List<IBirthdayable>();

            string enterLine = string.Empty;

            while ((enterLine = Console.ReadLine()) != "End")
            {
                string[] tokens = enterLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string classType = tokens[0];
                string name = tokens[1];

                if (classType == "Citizen")
                {
                    string age = tokens[2];
                    string id = tokens[3];
                    string birthday = tokens[4];

                    Citizen citizen = new Citizen(name, age, id, birthday);

                    birthdayGuys.Add(citizen);
                }
                else if (classType == "Pet")
                {
                    string birthDay = tokens[2];

                    Pet currentPet = new Pet(name, birthDay);

                    birthdayGuys.Add(currentPet);
                }
            }

            string year = Console.ReadLine();


            if (birthdayGuys.Any(x => x.Birthday.EndsWith(year)))
            {
                foreach (var dude in birthdayGuys)
                {
                    if (dude.Birthday.EndsWith(year))
                    {
                        Console.WriteLine(dude.Birthday);
                    }
                }
            }
        }
    }
}
