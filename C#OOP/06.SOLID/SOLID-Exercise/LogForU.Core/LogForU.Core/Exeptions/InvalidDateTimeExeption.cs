using System;

namespace LogForU.Core.Exeptions
{
    public class InvalidDateTimeExeption : Exception
    {
        private const string DefaultMessage =
            "Invalid DateTime format";

        public InvalidDateTimeExeption()
            : base(DefaultMessage)
        {
            
        }

        public InvalidDateTimeExeption(string message)
            : base(message)
        {
            
        }
    }
}
