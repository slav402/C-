using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];
            string[,] matrix = new string[rows, cols];
            int counter = 0;

            string theSnake = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = theSnake[counter % theSnake.Length].ToString();
                        counter++;
                    }    
                }
                else
                {
                    for (int j = cols-1; j >= 0; j--)
                    {
                        matrix[i, j] = theSnake[counter % theSnake.Length].ToString();
                        counter++;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
