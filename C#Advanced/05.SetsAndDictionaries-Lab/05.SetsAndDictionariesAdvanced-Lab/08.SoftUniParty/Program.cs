using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> list = new HashSet<string>();

            var input = Console.ReadLine();

            while (input!= "PARTY")
            {
                list.Add(input);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                list.Remove(input);

                input = Console.ReadLine();
            }


            if (list.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(list.Count);

                foreach (var item in list)
                {
                    var firstSign = item[0];

                    if (char.IsDigit(firstSign))
                    {
                        Console.WriteLine(item);
                    }
                }

                foreach (var item in list)
                {
                    var firstSign = item[0];

                    if (!char.IsDigit(firstSign))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
