using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> expresion = new Stack<string>(input.Reverse());

            while (expresion.Count > 1)
            {
                int firstOperand = int.Parse(expresion.Pop());
                string action = expresion.Pop();
                int secondOperand = int.Parse(expresion.Pop());

                if (action == "+")
                {
                    expresion.Push((firstOperand + secondOperand).ToString());
                }
                else
                {
                    expresion.Push((firstOperand - secondOperand).ToString());
                }
            }

            Console.WriteLine(expresion.Pop());
        }
    }
}
