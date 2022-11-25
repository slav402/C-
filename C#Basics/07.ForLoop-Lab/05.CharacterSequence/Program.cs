using System;

namespace _05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char leter = word[i];
                Console.WriteLine(leter);
            }
        }
    }
}
