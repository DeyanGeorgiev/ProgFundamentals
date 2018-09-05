using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Anonymous_Vox
{
    class Program
   
    {
        
        
        static void Main(string[] args)
        {
            string code = Console.ReadLine();

            List<string> forReplace = Console.ReadLine().Split("}{", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> result = new List<string>();

            //string regex = "(?<one>[A-Za-z]+)(?<stringToReplace>.+)(?<two>\\1)";

            Regex reg = new Regex("(?<one>[A-Za-z]+)(?<stringToReplace>.+)(?<two>\\1)");

            MatchCollection match = reg.Matches(code);
            
            
 

            int index = 0;
            int start = 0;

            string results = code.Substring(0, start);

            foreach (Match mat in match)
            {

                start = mat.Groups["one"].Index;

                results += mat.Groups["one"].Value;

                

                results += forReplace[index];


                results += mat.Groups["two"].Value;
                
                index++;
            }

            


            Console.WriteLine(results);
        }
    }
}