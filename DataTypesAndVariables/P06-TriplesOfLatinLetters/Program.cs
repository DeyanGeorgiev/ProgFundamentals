using System;

namespace P06_TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int take = int.Parse(Console.ReadLine());

            char n = (char) ('a' + take);

    
            for (char i = 'a'; i <= n-1; i++)
            {
                for (char j = 'a'; j <= n-1; j++)
                {
                    for (char k = 'a'; k <= n-1; k++)
                    {
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
        }
    }
}