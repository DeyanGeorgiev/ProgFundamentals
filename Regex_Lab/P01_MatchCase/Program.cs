using System;
using System.Text.RegularExpressions;

namespace P01_MatchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b[A-Z][a-z]+[ ][A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection match = Regex.Matches(names, regex);

            foreach (Match name in match)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}