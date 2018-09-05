using System;

namespace P03_LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] seq = new int[n];

            seq[0] = 1;

            for (int i = 1; i < seq.Length; i++)
            {
                int sum = 0;
                for (int j = Math.Max(0, i - k); j <= i - 1; j++)
                {
                    sum += seq[j];
                }

                seq[i] = sum;
            }

            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write(seq[i] + " ");
            }
            Console.WriteLine();
        }
    }
}