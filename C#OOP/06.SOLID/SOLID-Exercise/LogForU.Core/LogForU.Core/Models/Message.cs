using LogForU.Core.Enums;
using LogForU.Core.Exeptions;
using LogForU.Core.Models.Interfaces;
using LogForU.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Models
{
    public class Message : IMessage
    {
        private string createdTime;
        private string text;

        public Message(string createdTime, string text, ReportLevel reportLevel)
        {
            CreateTime = createdTime;
            Text = text;
            ReportLevel = reportLevel;
        }

        public string CreateTime
        {
            get => createdTime;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyCreatedTimeExeption();
                }

                if (!DateTimeValidator.ValidateDateTime(value))
                {
                    throw new InvalidDateTimeExeption();
                }

                createdTime = value;
            }
        }

        public string Text
        {
            get => text;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new EmptyCreatedTimeExeption();
                }

                text = value;
            }
        }

        public ReportLevel ReportLevel { get; }
    }
}
