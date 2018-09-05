using System;

namespace P03_PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintTriangle(num);
        }

        static void PrintTriangle(int num)
        {
            for (int col = 1; col <= num; col++)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write(row+" ");
                }

                Console.WriteLine();
            }

            for (int col = num - 1; col >= 1; col--)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write(row+" ");
                }

                Console.WriteLine();
            }
        }
    }
}