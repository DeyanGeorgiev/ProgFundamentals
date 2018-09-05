using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03_MatchHex
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex myRegex = new Regex(@"\b(?:0x)?[0-9A-F]+\b");
            
            string input = Console.ReadLine();

            MatchCollection myCollection = myRegex.Matches(input);

            
            List<string> result = new List<string>();
            foreach (Match item in myCollection)
            {
                result.Add(item.Value);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}