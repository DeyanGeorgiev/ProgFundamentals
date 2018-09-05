using System;
using System.IO;
using System.Linq;

namespace P02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input= File.ReadAllLines("input.txt");
            File.Delete("output.txt");

            var addNumbers = input.Select((l, i) => i + 1 + ". " + l);
            
            File.AppendAllLines("output.txt", addNumbers);

        }
    }
}