using System;

namespace P09_MultiplyEvenWithOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n= Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(MultipyOfEvenAndSum(n));
        }

        static int MultipyOfEvenAndSum(int n)
        {
            int sumOfEven = GetSumOfEven(n);
            int sumOfOdd = GetSumOfOdd(n);

            int sum = sumOfEven * sumOfOdd;

            return sum;
        }

        static int GetSumOfOdd(int n)
        {
            int sum = 0;

            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }

            return sum;
        }
        
        static int GetSumOfEven(int n)
        {
            int sum = 0;

            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }

            return sum;
        }
    }
}