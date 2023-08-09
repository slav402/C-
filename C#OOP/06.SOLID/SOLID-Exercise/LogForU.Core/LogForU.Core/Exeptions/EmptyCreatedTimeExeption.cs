using System;

namespace LogForU.Core.Exeptions
{
    public class EmptyCreatedTimeExeption : Exception
    {
        private const string DefaultMessage =
            "Created time cannot be null or whitespace";

        public EmptyCreatedTimeExeption()
            : base(DefaultMessage)
        {
            
        }

        public EmptyCreatedTimeExeption(string message)
            : base(message)
        {
            
        }
    }
}
