using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings someTestStack = new StackOfStrings();

            Console.WriteLine(someTestStack.IsEmpty());

            someTestStack.AddRange(new List<string>() {"1", "2", "3", "4"});

            Console.WriteLine(someTestStack.IsEmpty());

            foreach (var item in someTestStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
