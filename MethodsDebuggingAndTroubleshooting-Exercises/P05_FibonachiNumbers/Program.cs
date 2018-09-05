using System;

namespace P05_FibonachiNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine(Fib(n));
        }

        private static int Fib(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (n == a || n == b)
            {
                return b;
            }

            else
            {

                int sum = 2;

                for (int i = 2; i < n; i++)

                {
                    c = a + b;
                    a = b;
                    b = c;

                    sum += c;
                }

                return sum;
            }
        }
    }
}

