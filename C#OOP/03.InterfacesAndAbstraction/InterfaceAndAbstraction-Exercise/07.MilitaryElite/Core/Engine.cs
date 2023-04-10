using MilitaryElite.Core.Interfaces;
using MilitaryElite.Models;
using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private Dictionary<int, ISoldier> soldiersById;

        public Engine() 
        {
            soldiersById = new Dictionary<int, ISoldier>();
        } 

        public void Run()
        {
            string enter = string.Empty;


            while ((enter = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] inputData = enter.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine(ProcessInput(inputData));
                }
                catch (Exception ex)
                {
                    //оставяйки тук празно казвам "ако има ексцепшън - не прави нищо, просто продължи нататък със следващщата стъпка от цикъла"
                }
            }

        }

        private string ProcessInput(string[] inputData)
        {
            string rank = inputData[0];
            int id = int.Parse(inputData[1]);
            string firstName = inputData[2];
            string lastName = inputData[3];

            ISoldier soldier = null;

            switch (rank)
            {
                case "Private":
                    soldier = GetPrivate(id, firstName, lastName, decimal.Parse(inputData[4]));
                    break;
                case "LieutenantGeneral":
                    soldier = GetLieutenantGeneral(id, firstName, lastName, inputData);
                    break;
                case "Engineer":
                    soldier = GetEngineer(id, firstName, lastName, inputData);
                    break;
                case "Commando":
                    soldier = GetCommando(id, firstName, lastName, inputData);
                    break;
                case "Spy":
                    soldier = GetSpy(id, firstName, lastName, int.Parse(inputData[4]));
                    break;

            }

            soldiersById.Add(id, soldier);

            return soldier.ToString();
        }

        private ISoldier GetPrivate(int id, string firstName, string lastName, decimal salary)
        {
            return new Private(id, firstName, lastName, salary);
        }

        private ISoldier GetLieutenantGeneral(int id, string firstName, string lastName, string[] inputData)
        {
            var salary = decimal.Parse(inputData[4]);

            List<IPrivate> privates = new List<IPrivate>();

            for (int i = 5; i < inputData.Length; i++)
            {
                int privateID = int.Parse(inputData[i]);
                IPrivate soldier = (IPrivate)soldiersById[privateID];
                privates.Add(soldier);
            }

            return new LieutenantGeneral(id, firstName, lastName, salary, privates);
        }

        private ISoldier GetEngineer(int id, string firstName, string lastName, string[] inputData)
        {
            var salary = decimal.Parse(inputData[4]);
            
            List<IRepair> repairs = new List<IRepair>();

            bool isCorpsValid = Enum.TryParse<Corps>(inputData[5], out Corps corps);

            if (!isCorpsValid)
            {
                throw new ArgumentException();
            }

            for (int i = 6; i < inputData.Length; i+=2)
            {
                string repairPart = inputData[i];
                int repairHour = int.Parse(inputData[i+1]);
                IRepair part = new Reapair(repairPart, repairHour);
                repairs.Add(part);
            }

            return new Engineer(id, firstName, lastName, salary, corps, repairs);
        }

        private ISoldier GetCommando(int id, string firstName, string lastName, string[] inputData)
        {
            var salary = decimal.Parse(inputData[4]);

            List<IMission> missions = new List<IMission>();

            bool isCorpsValid = Enum.TryParse<Corps>(inputData[5], out Corps corps);

            if (!isCorpsValid)
            {
                throw new ArgumentException();
            }

            for (int i = 6; i < inputData.Length; i += 2)
            {
                string codeName = inputData[i];
                bool missionState = Enum.TryParse<State>(inputData[i+1], out State state);

                if (!missionState)
                {
                    continue;
                }

                IMission mission = new Mission(codeName, state);
                missions.Add(mission);
            }

            return new Commando(id, firstName, lastName, salary, corps, missions);
        }

        private ISoldier GetSpy(int id, string firstName, string lastName, int codeNumber)
        {
            return new Spy(id, firstName, lastName, codeNumber);
        }
    }
}
