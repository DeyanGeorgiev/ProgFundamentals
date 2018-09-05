using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05_KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex myRegex = new Regex(@"^(?<start>[A-Za-z]+)[\|<\\](?<dontneed>[0-9A-Za-z]+)[\|<\\](?<end>[A-Za-z]+)$");

            string input = Console.ReadLine();

            MatchCollection myMatch = myRegex.Matches(input);

            string findStrat = "";
            string findEnd = "";
            
            foreach (Match match in myMatch)
            {
                findStrat = match.Groups["start"].Value;
                findEnd = match.Groups["end"].Value;
            }
            
            string needToDecode = Console.ReadLine();

            
            
           Regex secRegex= new Regex(@"(?<start>{findStrat})(?<need>[a-z]*)(?<end>{findEnd})");
            
            


            MatchCollection secMatchCollection = secRegex.Matches(needToDecode);

            string result = "";
            
            foreach (Match item in secMatchCollection)
            {

                
                 result += item;
            }

            Console.WriteLine(result);

        }
    }
}