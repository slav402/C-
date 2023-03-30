using System;
using System.Numerics;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in phoneNumbers)
            {
                ICallable phone;

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

            foreach (var url in urls)
            {
                IBrowsable smartPhone = new Smartphone();

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
