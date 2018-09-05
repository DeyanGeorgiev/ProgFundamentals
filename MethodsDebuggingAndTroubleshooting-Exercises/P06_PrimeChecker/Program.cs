using System;


namespace P06_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(num));
        }

        static bool isPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                bool number = false;
                return number;
            }


            else
            {
                bool number;
                for (long a = 2; a <= Math.Sqrt(num); a++)
                {
                    if (num % a == 0)
                    {
                        number = false;
                        return number;
                    }
                }

                number = true;
                return number;
            }
        }
    }
}