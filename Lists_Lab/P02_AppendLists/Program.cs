using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02_AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = Console.ReadLine().Split('|');

            List<string> newList = new List<string>();

            for (int i = 0; i < list.Length; i++)
            {
                string[] newInput = list[i].Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                
                string merget = string.Join(" ", newInput);
                newList.Add(merget);
            }

            newList.Reverse();

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}