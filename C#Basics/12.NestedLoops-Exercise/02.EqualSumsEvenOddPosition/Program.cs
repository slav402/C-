using System;

public class Program
{
    public static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        for (int currentNum = startNum; currentNum <= endNum; currentNum++)
        {
            string testedNum = currentNum.ToString();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < testedNum.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += int.Parse(testedNum[i].ToString());
                }
                else
                {
                    sumOdd += int.Parse(testedNum[i].ToString());
                }
            }

            if (sumOdd == sumEven)
            {
                Console.Write($"{testedNum} ");
            }
        }
    }

}
