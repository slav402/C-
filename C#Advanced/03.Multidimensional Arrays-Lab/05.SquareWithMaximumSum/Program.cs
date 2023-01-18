using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            LoadingMatrix(matrix);

            int[] subMatrixCoordinates = new int[2];
            int maxSum = int.MinValue;

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    int currentSum = 0;
                    currentSum += matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        subMatrixCoordinates[0] = i;
                        subMatrixCoordinates[1] = j;
                    }
                }
            }

            int row = subMatrixCoordinates[0];
            int col = subMatrixCoordinates[1];

            Console.WriteLine($"{matrix[row,col]} {matrix[row, col+1]}");
            Console.WriteLine($"{matrix[row+1,col]} {matrix[row+1, col+1]}");

            Console.WriteLine(maxSum);
        }

        private static void LoadingMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentLine = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentLine[j];
                }
            }
        }
    }
}
