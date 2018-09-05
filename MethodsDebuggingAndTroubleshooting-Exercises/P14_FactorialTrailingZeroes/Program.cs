using System;
using System.Diagnostics.Tracing;
using System.Numerics;

namespace P14_FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());


            Console.WriteLine(TrailingZero(Factorial(num)));
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

        static int TrailingZero(BigInteger num)
        {
            int counter = 0;


            while ((num % 10).IsZero)
            {
                counter++;
                num /= 10;
            }

            return counter;
        }
    }
}