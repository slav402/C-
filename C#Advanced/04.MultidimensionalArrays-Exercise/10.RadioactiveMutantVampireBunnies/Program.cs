using System;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = size[0];
            int m = size[1];
            char[,] lair = new char[n, m];
            int playerRow = -1;
            int playerCol = -1;
            bool isDead = false;
            bool isFree = false;

            for (int i = 0; i < n; i++)
            {
                char[] enter = Console.ReadLine().ToCharArray();

                for (int j = 0; j < m; j++)
                {
                    lair[i, j] = enter[j];

                    if (lair[i, j] == 'P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }

            string roadToHell = Console.ReadLine();

            for (int i = 0; i < roadToHell.Length; i++)
            {
                switch (roadToHell[i])
                {
                    case 'R':
                        if (IsInRange(lair, playerRow, playerCol + 1))
                        {
                            if (IsThereBunnie(lair, playerRow, playerCol + 1))
                            {
                                isDead = true;
                                lair[playerRow, playerCol] = '.';
                                playerCol++;
                            }
                            else
                            {
                                lair[playerRow, playerCol] = '.';
                                playerCol++;
                                lair[playerRow, playerCol] = 'P';
                            }
                        }
                        else
                        {
                            isFree = true;
                            lair[playerRow, playerCol] = '.';
                        }
                        break;

                    case 'L':
                        if (IsInRange(lair, playerRow, playerCol - 1))
                        {
                            if (IsThereBunnie(lair, playerRow, playerCol - 1))
                            {
                                isDead = true;
                                lair[playerRow, playerCol] = '.';
                                playerCol--;
                            }
                            else
                            {
                                lair[playerRow, playerCol] = '.';
                                playerCol--;
                                lair[playerRow, playerCol] = 'P';
                            }
                        }
                        else
                        {
                            isFree = true;
                            lair[playerRow, playerCol] = '.';
                        }
                        break;

                    case 'U':
                        if (IsInRange(lair, playerRow-1, playerCol))
                        {
                            if (IsThereBunnie(lair, playerRow-1, playerCol))
                            {
                                isDead = true;
                                lair[playerRow, playerCol] = '.';
                                playerRow--;
                            }
                            else
                            {
                                lair[playerRow, playerCol] = '.';
                                playerRow--;
                                lair[playerRow, playerCol] = 'P';
                            }
                        }
                        else
                        {
                            isFree = true;
                            lair[playerRow, playerCol] = '.';
                        }
                        break;

                    case 'D':
                        if (IsInRange(lair, playerRow+1, playerCol))
                        {
                            if (IsThereBunnie(lair, playerRow+1, playerCol))
                            {
                                isDead = true;
                                lair[playerRow, playerCol] = '.';
                                playerRow++;
                            }
                            else
                            {
                                lair[playerRow, playerCol] = '.';
                                playerRow++;
                                lair[playerRow, playerCol] = 'P';
                            }
                        }
                        else
                        {
                            isFree = true;
                            lair[playerRow, playerCol] = '.';
                        }
                        break;

                        char[,] replica = new char[n, m];
                        LoadingReplica(replica, n, m);


                }
            }
        }

        private static void LoadingReplica(char[,] replica, int n, int m)
        {
            for (int i = 0; i < replica.GetLength(0); i++)
            {
                for (int j = 0; j < replica.GetLength(1); j++)
                {
                    replica[i, j] = '.';
                }
            }
        }

        private static bool IsThereBunnie(char[,] lair, int row, int col)
        {
            return lair[row, col] == 'B';
        }

        private static bool IsInRange(char[,] lair, int row, int col)
        {
            return row >= 0
            && row < lair.GetLength(0)
            && col >= 0
            && col < lair.GetLength(1);
        }
    }
}
