using System;
using System.Linq;

namespace P08_MostFrequentNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int maxCount = 0;
            int maxNum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                int count = 0;

                for (int j = i; j < inputArr.Length; j++)
                {
                    if (inputArr[i] == inputArr[j])
                    {
                        count++;
                    }
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    maxNum = inputArr[i];
                }
            }

            Console.WriteLine("{0}", maxNum);
        }
    }
}