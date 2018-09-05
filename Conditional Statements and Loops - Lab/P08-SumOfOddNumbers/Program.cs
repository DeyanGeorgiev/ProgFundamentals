using System;

namespace P08_SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num= int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                
                Console.WriteLine("{0} ",2*i-1);
                sum+=2*i-1;
            }
            Console.Write("Sum: {0} ",sum);
        }
    }
}