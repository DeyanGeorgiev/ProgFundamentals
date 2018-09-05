using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_SearchForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] operations = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            // first operation: keep first elements

            int numberToKeep = operations[0];
            int numberToRemove = list.Count - numberToKeep;

            list.Reverse();
            list.RemoveRange(0, numberToRemove);
            list.Reverse();


            // second operation: remove first elements

            int numberToRemove2 = operations[1];
            list.RemoveRange(0, numberToRemove2);

            // third operation : check for item and print

            int numbToCheck = operations[2];

            bool isNum = false;
            foreach (var number in list)
            {
                if (number == numbToCheck)
                {
                    isNum = true;
                    break;
                }
            }

            if (isNum)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}