using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> removedOdd = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    removedOdd.Add(input[i]);
                }
            }

            List<int> result = new List<int>();

            double average = removedOdd.Count > 0 ? removedOdd.Average() : 0.0;


            for (int i = 0; i < removedOdd.Count; i++)
            {
                if (removedOdd[i] > average)
                {
                    result.Add(removedOdd[i] + 1);
                }
                else
                {
                    result.Add(removedOdd[i] - 1);
                }
            }


            Console.WriteLine(string.Join(" ", result));
        }
    }
}