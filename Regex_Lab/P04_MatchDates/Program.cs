using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P04_MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex mRegex=new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b");
            //\b(?<day>\d{2})([.-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b
            
            string input= Console.ReadLine();

            MatchCollection myColection = mRegex.Matches(input);

            
            foreach (Match item in myColection)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

            
        }
    }
}