using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCountAndSum(int.Parse, arr => arr.Length, a => a.Sum());
        }

        private static void PrintCountAndSum(Func<string, int> parcer, Func<int[], int> countGeter, Func<int[], int> sumGeter)
        {
            int[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parcer).ToArray();

            Console.WriteLine(countGeter(arr));
            Console.WriteLine(sumGeter(arr));
        }
    }
}
