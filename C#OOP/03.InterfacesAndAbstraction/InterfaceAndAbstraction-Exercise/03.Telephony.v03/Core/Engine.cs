using System;
using System.Collections.Generic;
using System.Text;
using Telephony.Core.Interfaces;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            ICallable phone;

            foreach (var number in phoneNumbers)
            {
                if (number.Length == 10)
                {
                    phone = new Smartphone();
                }
                else
                {
                    phone = new StationaryPhone();
                }

                try
                {
                    Console.WriteLine(phone.Call(number));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            IBrowsable smartPhone = new Smartphone();

            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(smartPhone.Browse(url));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
