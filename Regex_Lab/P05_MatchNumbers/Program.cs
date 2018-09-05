using System;
using System.Text.RegularExpressions;

namespace P05_MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex= new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
            
            string input = Console.ReadLine();

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection)
            {
                Console.Write(match.Value+ " ");
            }
        }
    }
}