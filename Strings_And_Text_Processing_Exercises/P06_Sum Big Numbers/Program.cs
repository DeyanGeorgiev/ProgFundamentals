using System;
using System.Numerics;

namespace P06_Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BigInteger one= BigInteger.Parse(Console.ReadLine());
            BigInteger two= BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(one+two);
        }
    }
}