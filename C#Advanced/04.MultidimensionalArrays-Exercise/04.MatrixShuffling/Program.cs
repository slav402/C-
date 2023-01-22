using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = size[0];
            int m = size[1];
            string[,] matrix = new string[n, m];

            LoadMatrix(matrix);

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {
                if (CoordiantsValidator(command, matrix))
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    var transitionCell = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = transitionCell;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool CoordiantsValidator(string[] command, string[,] matrix)
        {
            if (command[0] != "swap")
            {
                return false;
            }
            else if (command.Length < 5 || command.Length > 5)
            {
                return false;
            }

            int row1 = int.Parse(command[1]);
            int col1 = int.Parse(command[2]);
            int row2 = int.Parse(command[3]);
            int col2 = int.Parse(command[4]);

            int matrixRows = matrix.GetLength(0)-1;
            int matrixCols = matrix.GetLength(1)-1;

            if (row1 < 0 || row2 < 0 || col1 < 0 || col2 < 0)
            {
                return false;
            }
            else if (row1 > matrixRows || row2 > matrixRows || col1 > matrixCols || col2 > matrixCols)
            {
                return false;
            }
            

            return true;
        }

        private static void LoadMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }
    }
}
