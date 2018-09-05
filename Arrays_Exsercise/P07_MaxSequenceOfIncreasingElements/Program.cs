using System;
using System.Linq;

namespace P07_MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int len = 1;
            int start = arr[0];


            string bestResult = "" + start;
            string result = "" + start;
            int bestLen = 0;

            for (int i = 1; i < arr.Length; i++)

            {
                if (start + 1 == arr[i])
                {
                    result += " " + arr[i];
                    start = arr[i];
                    len++;


                    if (bestLen < len)
                    {
                        bestLen = len;
                        bestResult = result;
                    }
                }

                else
                {
                    start = arr[i];
                    len = 1;
                    result = "" + start;
                }
            }

            Console.WriteLine(bestResult);
        }
    }
}

// todo: dve greshki