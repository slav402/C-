using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                        
            Dictionary<string, Dictionary<string, List<string>>> result = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!result.ContainsKey(continent))
                {
                    result.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!result[continent].ContainsKey(country))
                {
                    result[continent].Add(country, new List<string>());
                }

                result[continent][country].Add(city);
            }

            foreach (var cont in result)
            {
                Console.WriteLine("{0}:", cont.Key);

                foreach (var countr in cont.Value)
                {
                    Console.Write("{0} -> ", countr.Key);

                    for (int i = 0; i < countr.Value.Count; i++)
                    {
                        if (i != 0)
                        {
                            Console.Write(", ");
                        }

                        Console.Write("{0}", countr.Value[i]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
