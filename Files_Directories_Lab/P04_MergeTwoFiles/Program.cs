using System;
using System.Collections.Generic;
using System.IO;

namespace P04_MergeTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("Output.txt");

            string[] text1 = File.ReadAllLines("FileOne.txt");
            string[] text2 = File.ReadAllLines("FileTwo.txt");

            List<string> result = new List<string>();

            foreach (var i in text1)
            {
                result.Add(i);
            }

            foreach (var i in text2)
            {
                result.Add(i);
            }

            result.Sort();

            File.AppendAllLines("Output.txt", result);
        }
    }
}