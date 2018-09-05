using System;

namespace P04_SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool[] primeFinder = new Boolean[number + 1];

            for (int i = 2; i < primeFinder.Length; i++)
            {
                primeFinder[i] = true;
            }

            primeFinder[0] = primeFinder[1] = false;

            for (int i = 2; i < primeFinder.Length; i++)
            {
                if (primeFinder[i])
                {
                    Console.Write($"{i} ");

                    for (int j = 2 * i; j < primeFinder.Length; j += i)
                    {
                        primeFinder[j] = false;
                    }
                }
            }
        }
    }
}