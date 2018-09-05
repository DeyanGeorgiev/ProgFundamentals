using System;

namespace P13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' ||
                symbol == 'o' ||
                symbol == 'e' ||
                symbol == 'i' ||
                symbol == 'u' ||
                symbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(symbol))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
                
        }
    }
}