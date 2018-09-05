using System;
using System.Linq;

namespace P08_CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] condenseArr = new int[inputArr.Length-1];


            if (inputArr.Length == 1)
            {
                Console.WriteLine("{0}", inputArr[0]);
                return;
            }

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = 0; j < condenseArr.Length - i; j++)
                {
                    condenseArr[j] = inputArr[j] + inputArr[j + 1];

                }

                inputArr = condenseArr;
            }


            Console.WriteLine(inputArr[0]);
        }
    }
}