using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        private string number;
        private string site;

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

        public string Site 
        { 
            get => site;
            set 
            {
                foreach (var ch in value)
                {
                    if (char.IsDigit(ch))
                    {
                        throw new ArgumentException("Invalid URL!");
                    }
                }

                site = value;
            } 
        }

        public void Browsing()
        {
            Console.WriteLine($"Browsing: {site}!");
        }

        public void Calling()
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
