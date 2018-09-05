using System;
using System.Linq;

namespace P05_CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            if (firstArr.Length > secondArr.Length && firstArr[0]== secondArr[0])
            {
                Console.WriteLine(secondArr);
                Console.WriteLine(firstArr);
            }

            else if (firstArr.Length == secondArr.Length)
            {
                if (firstArr[0] > secondArr[0])
                {
                    Console.WriteLine(secondArr);
                    Console.WriteLine(firstArr);
                }
                else
                {
                    Console.WriteLine(firstArr);
                    Console.WriteLine(secondArr);
                }
            }
        }
    }
}

// todo : vrushta 1 greshka