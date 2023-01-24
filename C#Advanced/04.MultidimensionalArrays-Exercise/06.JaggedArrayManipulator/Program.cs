using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = new int[n][];

            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedMatrix[i] = currentLine;
            }

            for (int i = 0; i < jaggedMatrix.Length-1; i++)
            {
                if (jaggedMatrix[i].Length == jaggedMatrix[i+1].Length)
                {
                    for (int j = 0; j < jaggedMatrix[i].Length; j++)
                    {
                        jaggedMatrix[i][j] *= 2;
                        jaggedMatrix[i+1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jaggedMatrix[i].Length; j++)
                    {
                        jaggedMatrix[i][j] /= 2;
                    }

                    for (int j = 0; j < jaggedMatrix[i+1].Length; j++)
                    {
                        jaggedMatrix[i+1][j] /= 2;
                    }
                }
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0].ToLower() != "end")
            {
                string command = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row >= 0 && row < jaggedMatrix.Length && col >= 0 && col < jaggedMatrix[row].Length)
                {
                    if (command == "Add" )
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                for (int j = 0; j < jaggedMatrix[i].Length; j++)
                {
                    Console.Write($"{jaggedMatrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
