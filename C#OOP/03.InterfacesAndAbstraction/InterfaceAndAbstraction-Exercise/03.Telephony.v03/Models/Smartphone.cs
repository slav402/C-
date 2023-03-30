﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (!ValidatePhoneNumber(number))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (!ValidateUrl(url))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }


        private bool ValidatePhoneNumber(string adres)
            => adres.All(c => char.IsDigit(c));
        private bool ValidateUrl(string url)
            => url.All(c => !char.IsDigit(c));
    }
}
