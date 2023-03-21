using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int StatMinValue = 0;
        private const int StatMaxValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Endurance
        {
            get => endurance;
            set
            {
                Validator(value, nameof(Endurance));
                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint;
            set
            {
                Validator(value, nameof(Sprint));
                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble;
            set
            {
                Validator(value, nameof(Dribble));
                dribble = value;
            }
        }

        public int Passing
        {
            get => passing;
            set
            {
                Validator(value, nameof(Passing));
                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting;
            set
            {
                Validator(value, nameof(Shooting));
                shooting = value;
            }
        }

        public double OverallSkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;

        private void Validator(int value, string skill)
        {
            if (value < StatMinValue || value > StatMaxValue)
            {
                throw new ArgumentException($"{skill} should be between {StatMinValue} and {StatMaxValue}.");
            }
        }
    }
}
