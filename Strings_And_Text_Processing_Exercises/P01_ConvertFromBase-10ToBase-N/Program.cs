using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace P01_ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            int first = (int) input[0];
            BigInteger sec = input[1];

            BigInteger remainder;
            string result = string.Empty;
            while (sec > 0)
            {
                remainder = sec % first;
                sec /= first;
                result = remainder.ToString() + result;
            }


            Console.WriteLine(result);
        }
    }
}