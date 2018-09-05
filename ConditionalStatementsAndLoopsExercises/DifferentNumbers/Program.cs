using System;
using System.Globalization;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 - num1<5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = num1; i <= num2; i++)
            {
                for (int j = i; j <= num2; j++)
                {
                    for (int k = j; k <= num2; k++)
                    {
                        for (int l = k; l <= num2; l++)
                        {
                            for (int m = l; m <= num2; m++)
                            {
                                if (m > l && l > k && k > j && j > i)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}