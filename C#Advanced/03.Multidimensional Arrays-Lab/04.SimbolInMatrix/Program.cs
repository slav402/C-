using System;
using System.Linq;

namespace _04.SimbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            LoadingMatrix(matrix);

            char specialSimbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (matrix[i,j] == specialSimbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{specialSimbol} does not occur in the matrix");
        }

        private static void LoadingMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] currentLine = Console.ReadLine().ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentLine[j];
                }
            }
        }
    }
}
