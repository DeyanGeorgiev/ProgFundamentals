using System;
using System.Linq;

namespace P06_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            
            int len = 1;
            int start = inputArr[0];

            int bestLen = 0;
            int bestStart = 0;
            for (int i = 1; i < inputArr.Length; i++)
            {
                if (start == inputArr[i])
                {
                   
                    len++;

                    if (bestLen < len)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }

                if (start != inputArr[i])
                {
                    start = inputArr[i];
                    len = 1;
                }
            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestStart+" ");
            }
            
            



        }
    }
}