using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] listOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] listOfSites = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Phone phone = new Phone();
            Smartphone smartPhone = new Smartphone();

            foreach (var number in listOfNumbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        smartPhone.Number = number;
                        smartPhone.Calling();
                    }
                    else
                    {
                        phone.Number = number;
                        phone.Calling();
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var site in listOfSites)
            {
                try
                {
                    smartPhone.Site = site;
                    smartPhone.Browsing();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
