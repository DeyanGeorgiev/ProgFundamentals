using System;

namespace P09_RefacorSpecalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = 0; int count = 0; bool result = false;
            for (int i = 1; i <= input; i++)
            {
                count = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                result = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{count} -> {result}");
                total = 0;
                i = count;
            }

        }
    }
}