using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];
            int removedKnights = 0;

            for (int i = 0; i < n; i++)
            {
                string enter = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = enter[j].ToString();
                }
            }

            while (true)
            {
                int maxAtacks = 0;
                int rowMaxAtacker = -1;
                int colMaxAtacker = -1;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i,j] != "K")
                        {
                            continue;
                        }

                        int count = GetMaxAtaks(i, j, matrix);  

                        if (count > maxAtacks)
                        {
                            maxAtacks = count;
                            rowMaxAtacker = i;
                            colMaxAtacker = j;
                        }
                    }
                }

                if (maxAtacks == 0)
                {
                    break;
                }

                matrix[rowMaxAtacker, colMaxAtacker] = "0";
                removedKnights++;
            }

            Console.WriteLine(removedKnights);
        }

        private static int GetMaxAtaks(int row, int col, string[,] matrix)
        {
            int count = 0;

            if (IsThereKnight(matrix, row - 2, col + 1))
            {
                count++;
            }
            if (IsThereKnight(matrix, row - 2, col - 1))
            {
                count++;
            }
            if (IsThereKnight(matrix, row + 2, col + 1))
            {
                count++;
            }
            if (IsThereKnight(matrix, row + 2, col - 1))
            {
                count++;
            }
            if (IsThereKnight(matrix, row - 1, col - 2))
            {
                count++;
            }
            if (IsThereKnight(matrix, row + 1, col - 2))
            {
                count++;
            }
            if (IsThereKnight(matrix, row - 1, col + 2))
            {
                count++;
            }
            if (IsThereKnight(matrix, row + 1, col + 2))
            {
                count++;
            }

            return count;
        }

        private static bool IsThereKnight(string[,] matrix, int row, int col)
        {
            if (!IsInRange(matrix.GetLength(0), row, col))
            {
                return false;
            }

            return matrix[row, col] == "K";
        }

        private static bool IsInRange(int lenght, int row, int col)
        {
            return row >= 0
            && row < lenght
            && col >= 0
            && col < lenght;
        }
    }
}
