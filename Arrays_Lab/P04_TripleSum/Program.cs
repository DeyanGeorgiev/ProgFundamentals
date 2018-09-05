using System;
using System.Linq;

namespace P04_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray();

            bool weHaveTriple = TripleSum(n);

            if (weHaveTriple == false)
            {
                Console.WriteLine("No");
            }
        }

        static bool TripleSum(int[] n)
        {
            bool TripleSum = false;

            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i+1; j < n.Length; j++)
                {
                    int sum = n[i] + n[j];

                    if (n.Contains(sum))
                    {
                        Console.WriteLine($"{n[i]} + {n[j]} == {sum}");
                        TripleSum = true;
                    }
                }
            }

            return TripleSum;
        }
    }
}