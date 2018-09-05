using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> reversedList = new List<int>();

            foreach (var number in inputList)
            {
                int num = number;
                int rev = 0;

                while (num > 0)
                {
                    rev = rev * 10 + num % 10;
                    num /= 10;
                }

                reversedList.Add(rev);
            }
            
            int total = reversedList.Sum(x => Convert.ToInt32(x));

            Console.WriteLine(total);
        }
    }
}