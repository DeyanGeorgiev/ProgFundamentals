using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());


            int totalSum = 0;
            int count = 1;


            for (int i = num1; i >= 1; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    int multipl = i * j;
                    int multyProduct = multipl * 3;

                    totalSum += multyProduct;

                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                        return;
                        
                    }

                    count++;
                }
            }
            
            
            if (totalSum < maxSum)
            {
                Console.WriteLine($"{count-1} combinations");
                Console.WriteLine($"Sum: {totalSum}");
                        
            }
        }
    }
}