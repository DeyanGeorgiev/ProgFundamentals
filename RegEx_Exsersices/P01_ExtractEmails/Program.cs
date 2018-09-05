using System;
using System.Text.RegularExpressions;

namespace P01_ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string input = Console.ReadLine();
            
            string regex= @"(?<= )[a-zA-Z0-9]+([._-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+(\-[a-zA-Z0-9]+)*(\.[a-zA-z0-9]+)+";

            MatchCollection match = Regex.Matches(input, regex);
               
            foreach (Match item in match)
            {
                Console.WriteLine(item);
                
               
            }


        }
    }
}