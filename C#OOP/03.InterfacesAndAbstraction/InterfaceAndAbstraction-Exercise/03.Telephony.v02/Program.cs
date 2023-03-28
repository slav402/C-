using System;
using System.Numerics;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] listOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] listOfSites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StationaryPhone phone = new StationaryPhone();
            Smartphone smartPhone = new Smartphone();

            foreach (string number in listOfNumbers)
            {
                try
                {
                    string result = number.Length == 7 
                        ? phone.Call(number) 
                        : smartPhone.Call(number);

                    Console.WriteLine(result);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (string site in listOfSites)
            {
                try
                {
                    string result = smartPhone.Browse(site);

                    Console.WriteLine(result);
                }
                catch (ArgumentException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
