using System;

namespace LogForU.Core.Exeptions
{
    public class InvalidPathExeption : Exception
    {
        private const string DeffaultMessage =
            "Path is invalid or empty";

        public InvalidPathExeption()
            : base(DeffaultMessage)
        {
            
        }

        public InvalidPathExeption(string message)
            : base(message)
        {
            
        }
    }
}
