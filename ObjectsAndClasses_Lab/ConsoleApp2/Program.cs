using System;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger f = 1;

            for (int i = 2; i <= input; i++)
            {
                f *= i;
                
            }
            
            Console.WriteLine(f);
        }
    }
}