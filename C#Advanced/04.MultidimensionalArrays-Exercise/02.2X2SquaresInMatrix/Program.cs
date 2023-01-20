using System;
using System.Linq;

namespace _02._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = size[0];
            int m = size[1];
            char[,] matrix = new char[n,m];
            int counter = 0;

            GetMatrix(matrix);


            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < m-1; j++)
                {
                    if (matrix[i,j] == matrix[i, j+1] &&
                        matrix[i,j] == matrix[i+1, j+1] &&
                        matrix[i,j] == matrix[i+1, j])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        private static void GetMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }
    }
}
