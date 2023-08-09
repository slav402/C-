using System;

namespace LogForU.Core.Exeptions
{
    public class EmptyFileExtensionExption : Exception
    {
        private const string DeffaultMessage =
            "File extension cannot be null or whitespace";

        public EmptyFileExtensionExption()
            : base(DeffaultMessage)
        {
            
        }

        public EmptyFileExtensionExption(string message)
            : base(message)
        {
            
        }
    }
}
