using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] amountsOfMoney = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            amountsOfMoney = Select(amountsOfMoney, x => x * 1.2m);

            foreach (var bill in amountsOfMoney)
            {
                Console.WriteLine($"{bill:f2}");
            }
        }

        private static decimal[] Select(decimal[] amountsOfMoney, Func<decimal, decimal> addVAT)
        {
            decimal[] array = new decimal[amountsOfMoney.Length];

            for (int i = 0; i < amountsOfMoney.Length; i++)
            {
                array[i] = addVAT(amountsOfMoney[i]);
            }

            return array;
        }
    }
}
