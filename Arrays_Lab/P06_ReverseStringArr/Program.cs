using System;
using System.Linq;

namespace P06_ReverseStringArr
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine()?.Split(' ').ToArray();


            var result = strArr.Reverse();


            Console.WriteLine(string.Join(" ", result));
        }
    }
}