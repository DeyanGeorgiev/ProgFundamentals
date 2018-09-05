using System;
using System.Numerics;

namespace P13_Factorial_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            BigInteger result = Factorial(num);

            Console.WriteLine(result);
        }

        private static BigInteger Factorial(BigInteger num)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial = i * factorial;
            }

            return factorial;
        }
    }
}