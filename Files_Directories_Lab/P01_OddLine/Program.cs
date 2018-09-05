using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace P01_OddLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = File.ReadAllLines("Input.txt");

        File.Delete("odd-lines.txt");
//
//            for (int i = 1; i < input.Length; i+=2)
//            {
//                File.AppendAllText("odd-lines.txt", input[i]+ Environment.NewLine);
//            }

            var readOdd = input.Where((l, i) => i % 2 == 1);
            
            File.WriteAllLines("odd-lines.txt", readOdd);

        }
    }
}