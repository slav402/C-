using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            LoadingMatrix(matrix);

            int sum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }

        private static void LoadingMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentLine[j];
                }
            }
        }
    }
}
