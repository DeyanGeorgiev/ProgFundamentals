using System;
using System.Linq;

namespace P04_ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();

            Console.WriteLine(Reverse(input));
        }

        static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}