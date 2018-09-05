using System;
using System.Linq;

namespace P02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int rotationsNum= int.Parse(Console.ReadLine());
            
            int[] sumArr= new int[inputArr.Length];

            for (int i = 0; i < rotationsNum; i++)
            {
                Shift(inputArr);
                SumShift(sumArr, inputArr);
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }

        private static void SumShift(int[] sumArr, int[] input)
        {
            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] += input[i];
            }
        }

        private static void Shift(int[] input)
        {
            int lastN = input[input.Length - 1];

            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }

            input[0] = lastN;
        }
    }
}