using System;

namespace P09_IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputArr = Console.ReadLine().ToCharArray();

            foreach (char alfa in inputArr)
            {
                Console.WriteLine("{0} -> {1}", alfa, alfa - 97);
            }
        }
    }
} 