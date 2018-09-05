using System;
using System.Linq;

namespace P03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = inputArr.Length / 4;


            int[] leftArr = new int[k];
            int[] middleArr = new int[2 * k];
            int[] rightArr = new int[k];


            for (int i = 0; i < leftArr.Length; i++)
            {
                leftArr[i] = inputArr[i];
            }

            for (int i = 0; i < middleArr.Length; i++)
            {
                middleArr[i] = inputArr[k + i];
            }

            for (int i = 0; i < rightArr.Length; i++)
            {
                rightArr[i] = inputArr[(3 * k) + i];
            }

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);


            int[] mergeLandR = new int[middleArr.Length];


            int index = 0;

            foreach (var num in leftArr)
            {
                mergeLandR[index++] = num;
            }

            foreach (var num in rightArr)
            {
                mergeLandR[index++] = num;
            }

            int[] result = new int[mergeLandR.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = mergeLandR[i] + middleArr[i];
            }


            Console.WriteLine(string.Join(" ", result));
        }
    }
}