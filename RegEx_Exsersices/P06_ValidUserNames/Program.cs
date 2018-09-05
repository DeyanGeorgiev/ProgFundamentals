using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P06_ValidUserNames
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<string> operative = new List<string>();

            if (!string.IsNullOrEmpty(input) && input.Length < 9999)
            {
                string[] separateNames = input
                    .Split(new[] {' ', '/', '\\', '(', ')'},
                        StringSplitOptions.RemoveEmptyEntries);

                var matching = "^[^0-9][a-zA-Z0-9_]+$";


                foreach (var item in separateNames)
                {
                    if (Regex.IsMatch(item, matching) && (item.Length >= 3 && item.Length <= 25))
                    {
                        operative.Add(item);
                    }
                }
            }


            int currSum = 0;
            string result = "";
            int sum = 0;


            for (int i = 0; i < operative.Count - 1; i++)
            {
                currSum = operative[i].Length + operative[i + 1].Length;


                if (currSum > sum)
                {
                    sum = currSum;
                    result = operative[i] + Environment.NewLine + operative[i + 1];
                }
            }


            Console.WriteLine(result);
        }
    }
}