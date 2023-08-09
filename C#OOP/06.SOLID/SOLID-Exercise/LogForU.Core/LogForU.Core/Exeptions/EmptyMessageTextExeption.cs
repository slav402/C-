using System;

namespace LogForU.Core.Exeptions
{
    public class EmptyMessageTextExeption : Exception
    {
        private const string DefaultMessage =
            "Message text cannot be null or whitespace";

        public EmptyMessageTextExeption()
            : base(DefaultMessage)
        {
            
        }

        public EmptyMessageTextExeption(string message)
            : base(message)
        {
            
        }
    }
}
