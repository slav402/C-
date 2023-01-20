using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int sumMainDiag = 0;
            int sumSecDiag = 0;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];

                    if (i == j)
                    {
                        sumMainDiag += input[j];
                        sumSecDiag += input[n - j - 1];
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumMainDiag - sumSecDiag));
        }
    }
}
