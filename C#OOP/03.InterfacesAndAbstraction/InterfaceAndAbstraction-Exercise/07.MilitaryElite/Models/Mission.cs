﻿using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMIssion()
        {
            State = State.Finished;
        }

        public override string ToString() => $"Code Name: {CodeName} State: {State}";
    }
}
