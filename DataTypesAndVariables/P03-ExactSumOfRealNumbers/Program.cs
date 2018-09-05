using System;


namespace P03_ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
               int num = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < num; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }


            Console.WriteLine(sum);
        }
    }
}