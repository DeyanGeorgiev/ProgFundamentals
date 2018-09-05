using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            var minLenght = Math.Min(firstArr.Length, secondArr.Length);

            int sumL = 0;
            int sumR = 0;

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    sumL++;
                }

                if (firstArr[firstArr.Length - i - 1] == secondArr[secondArr.Length - i - 1])
                {
                    sumR++;
                }
            }


            int result = Math.Max(sumL, sumR);
            Console.WriteLine(result);
        }
    }
}