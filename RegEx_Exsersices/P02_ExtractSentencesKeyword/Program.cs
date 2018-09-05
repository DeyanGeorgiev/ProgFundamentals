using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_ExtractSentencesKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = Console.ReadLine().Split(new char[]{'.', '?', '!'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();


            string pattern = $@"\b{input}\b";


            Regex regexp = new Regex(pattern);


            foreach (var item in arr)
            {
                if (regexp.IsMatch(item))
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}