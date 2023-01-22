using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = size[0];
            int m = size[1];
            int[,] matrix = new int[n, m];
            int maxSum = int.MinValue;
            int[] subMatrixCoord = new int[2];
            
            LoadMatrix(matrix);

            for (int i = 0; i < n-2; i++)
            {
                for (int j = 0; j < m-2; j++)
                {
                    int currentSum = SubMatrixSum(i, j, matrix);

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        subMatrixCoord[0] = i;
                        subMatrixCoord[1] = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            PrintSubMatrix(subMatrixCoord, matrix);
        }

        private static void PrintSubMatrix(int[] subMatrixCoord, int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static int SubMatrixSum(int i, int j, int[,] matrix)
        {
            int sum = 0;

            for (int n = i; n < i+3; n++)
            {
                for (int m = j; m < j+3; m++)
                {
                    sum += matrix[n, m];
                }
            }
            return sum;
        }

        private static void LoadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }
    }
}
