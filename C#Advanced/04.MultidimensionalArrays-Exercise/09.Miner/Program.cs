using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[matrixSize, matrixSize];
            int minerRow = -1;
            int minerCol = -1;
            int totalCoals = 0;
            bool isTheEnd = false;

            string[] roadToHell = Console.ReadLine().Split();

            for (int i = 0; i < matrixSize; i++)
            {
                string[] enter = Console.ReadLine().Split();

                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = enter[j].ToString();

                    if (matrix[i, j] == "s")
                    {
                        minerRow = i;
                        minerCol = j;
                    }
                    else if (matrix[i, j] == "c")
                    {
                        totalCoals++;
                    }
                }
            }

            for (int i = 0; i <= roadToHell.Length; i++)
            {
                if (totalCoals == 0)
                {
                    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                    break;
                }
                else if (isTheEnd)
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    break;
                }
                else if (i == roadToHell.Length)
                {
                    Console.WriteLine($"{totalCoals} coals left. ({minerRow}, {minerCol})");
                    break;
                }

                switch (roadToHell[i])
                {
                    case "right":
                        if (IsInRange(matrixSize, minerRow, minerCol+1))
                        {
                            minerCol++;
                            totalCoals -= Action(matrix, minerRow, minerCol);
                            isTheEnd = (matrix[minerRow, minerCol] == "e");
                        }
                        break;

                    case "left":
                        if (IsInRange(matrixSize, minerRow, minerCol - 1))
                        {
                            minerCol--;
                            totalCoals -= Action(matrix, minerRow, minerCol);
                            isTheEnd = (matrix[minerRow, minerCol] == "e");
                        }
                        break;

                    case "up":
                        if (IsInRange(matrixSize, minerRow - 1, minerCol))
                        {
                            minerRow--;
                            totalCoals -= Action(matrix, minerRow, minerCol);
                            isTheEnd = (matrix[minerRow, minerCol] == "e");
                        }
                        break;

                    case "down":
                        if (IsInRange(matrixSize, minerRow + 1, minerCol))
                        {
                            minerRow++;
                            totalCoals -= Action(matrix, minerRow, minerCol);
                            isTheEnd = (matrix[minerRow, minerCol] == "e");
                        }
                        break;
                }
            }
        }

        private static int Action(string[,] matrix, int minerRow, int minerCol)
        {
            if (matrix[minerRow, minerCol] == "c")
            {
                matrix[minerRow, minerCol] = "*";
                return 1;
            }
            return 0;
        }

        private static bool IsInRange(int matrixSize, int row, int col)
        {
            return row >= 0
            && row < matrixSize
            && col >= 0
            && col < matrixSize;
        }
    }
}
