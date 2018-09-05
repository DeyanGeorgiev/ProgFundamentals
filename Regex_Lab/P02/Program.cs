using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex myRegex = new Regex(@"\b\+359([-]2{1}[-]2{3}[-]2{4})\b|\b\+359([ ]2{1}[ ]2{3}[ ]2{4})\b");


            MatchCollection myCollection = myRegex.Matches(input);

            List<string> result = new List<string>();

            foreach (Match item in myCollection)
            {
                
                
                result.Add(item.ToString().Trim() );
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}