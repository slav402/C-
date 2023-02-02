using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
			Dictionary<char, int> symbols = new Dictionary<char, int>();

			string input = Console.ReadLine();

			for (int i = 0; i < input.Length; i++)
			{
				if (!symbols.ContainsKey(input[i]))
				{
					symbols.Add(input[i], 0);
				}

				symbols[input[i]]++;
			}

			symbols = symbols.OrderBy(x => x.Key).ToDictionary(y => y.Key, z => z.Value);

			foreach (var item in symbols)
			{
				Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
			}
		}
    }
}
