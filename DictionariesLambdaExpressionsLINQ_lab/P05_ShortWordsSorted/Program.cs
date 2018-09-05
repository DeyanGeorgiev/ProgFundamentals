using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .ToLower()
                .Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", list));
        }
    }
}