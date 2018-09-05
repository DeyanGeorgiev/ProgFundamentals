using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();

            Dictionary<string, int> operative = new Dictionary<string, int>();

            foreach (var word in input)
            {
                int count = 1;
                if (operative.ContainsKey(word) == false)
                {
                    operative.Add(word, count);
                }

                else
                {
                    operative[word]++;
                }
            }


            List<string> result = new List<string>();

            foreach (var pair in operative)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}