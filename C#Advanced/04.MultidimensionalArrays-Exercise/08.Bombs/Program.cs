using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            

            LoadMatrix(matrix);

            string[] bombCoordinates = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < bombCoordinates.Count(); i++)
            {
                int[] currentBomb = bombCoordinates[i].Split(',').Select(int.Parse).ToArray();

                int bombRow = currentBomb[0];
                int bombCol = currentBomb[1];
                int damage = 0;

                if (matrix[bombRow, bombCol] > 0)
                {
                    damage = matrix[bombRow, bombCol];
                }

                for (int j = bombRow-1; j <= bombRow+1; j++)
                {
                    for (int k = bombCol-1; k <= bombCol+1; k++)
                    {
                        if (IsValid(matrix.GetLength(0), j, k) && matrix[j,k] > 0)
                        {
                            matrix[j, k] -= damage;
                        }
                    }
                }
            }

            int liveCells = 0;
            int liveCellsSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] > 0)
                    {
                        liveCells++;
                        liveCellsSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Alive cells: {0}", liveCells);
            Console.WriteLine("Sum: {0}", liveCellsSum);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValid(int lenght, int row, int col)
        {
            return row >= 0
            && row < lenght
            && col >= 0
            && col < lenght;
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
