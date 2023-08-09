using System;

namespace LogForU.Core.Exeptions
{
    public class EmptyFileNameExption : Exception
    {
        private const string DefaultMessage =
            "File name cannot be null or whitespace";

        public EmptyFileNameExption()
            : base(DefaultMessage)
        {
            
        }

        public EmptyFileNameExption(string message)
            : base(message)
        {
            
        }
    }
}
