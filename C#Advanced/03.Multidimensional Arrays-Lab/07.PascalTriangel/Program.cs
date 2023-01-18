using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int matrixRows = int.Parse(Console.ReadLine());

		long[][] pascalTriangle = new long[matrixRows][];

		for (int i = 0; i < matrixRows; i++)
		{
			pascalTriangle[i] = new long[i + 1];

			int currentRowLenght = pascalTriangle[i].Count();

			for (int j = 0; j < currentRowLenght; j++)
			{
				if (j == 0 || j == currentRowLenght - 1)
				{
					pascalTriangle[i][j] = 1;
				}
				else
				{
					pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
				}
			}
		}




		for (int i = 0; i < matrixRows; i++)
		{
			foreach (var j in pascalTriangle[i])
			{
				Console.Write("{0} ", j);
			}

			Console.WriteLine();
		}
	}
}