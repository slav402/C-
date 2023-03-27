using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    class Phone : ICallable
    {
        private string number;

        public string Number
        {
            get => number;
            set 
            {
                foreach (var ch in value)
                {
                    if (!char.IsDigit(ch))
                    {
                        throw new ArgumentException("Invalid number!");
                    }
                }

                number = value;
            }
        }

        public void Calling()
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
