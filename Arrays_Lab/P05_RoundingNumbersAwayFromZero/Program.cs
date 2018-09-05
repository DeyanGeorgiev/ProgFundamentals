using System;
using System.Linq;

namespace P05_RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                var rounded = Math.Round(number[i], 0, MidpointRounding.AwayFromZero);

                Console.WriteLine("{0} => {1}",number[i], rounded);
            }
            
            
        }

    }
}