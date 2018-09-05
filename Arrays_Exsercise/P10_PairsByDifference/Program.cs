using System;
using System.Linq;

namespace P10_PairsByDifference
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int difference = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                int actualNum = inputArr[i];

                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    int pair = Math.Max(inputArr[j], actualNum) - Math.Min(inputArr[j], actualNum);


                    if (pair == difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}