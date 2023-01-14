using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = Console.ReadLine();

            Stack<int> bracketIndex = new Stack<int>();

            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    bracketIndex.Push(i);
                }
                else if (expresion[i] == ')')
                {
                    int subExpresionStratIndex = bracketIndex.Pop();
                    int subExpresionLenght = i - subExpresionStratIndex + 1;
                    string substring = expresion.Substring(subExpresionStratIndex, subExpresionLenght);

                    Console.WriteLine(substring);
                }
            }
        }
    }
}
