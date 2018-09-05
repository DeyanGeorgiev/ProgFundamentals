using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04_CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            int[] firstLine = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] secondLine = Console.ReadLine()
                .Split('|');

            Regex myRegex = new Regex("(?<item>[<])");

            for (int i = 0; i < secondLine.Length; i++)
            {
                MatchCollection myMach = myRegex.Matches(secondLine[i]);

                foreach (Match match in myMach)
                {
                    myList.Add(secondLine[i]);
                }
            }


            int skip = firstLine[0] + 1;
            int take = firstLine[1];

            List<string> resultList = new List<string>();

            foreach (var item in myList)
            {
                string result = new string(item.Skip(skip).Take(take).ToArray());
                resultList.Add(result);
            }


            Console.WriteLine(string.Join(", ", resultList));
        }
    }
}