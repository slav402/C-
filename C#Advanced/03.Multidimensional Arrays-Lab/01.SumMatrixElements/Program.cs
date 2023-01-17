using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] rangeInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

		int rows = rangeInput[0];
		int columns = rangeInput[1];
		int matrixSum = 0;

		for (int i = 0; i < rows; i++)
		{
			int[] inputMembers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

			matrixSum += inputMembers.Sum();
		}

		Console.WriteLine("{0}\n{1}\n{2}", rows, columns, matrixSum);
	}
}