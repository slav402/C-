using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (!ValidatePhoneNumber(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Dialing... {number}";
        }

        private bool ValidatePhoneNumber(string number)
        {
            return number.All(char.IsDigit);
        }
    }
}
