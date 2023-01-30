using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.PatkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            char[] separator = new char[] { ',', ' ' };

            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                string move = input[0];
                string number = input[1];

                if (move == "IN")
                {
                    carNumbers.Add(number);
                }
                else
                {
                    carNumbers.Remove(number);
                }

                input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            }

            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in carNumbers)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
