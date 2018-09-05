﻿using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());


            int count = 0;


            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    int sumCombinations = i + j;

                    if (sumCombinations == magicNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicNum}");
                        return;
                    }


                    count++;
                }
            }


            Console.WriteLine($"{count} combinations - neither equals {magicNum}");
        }
    }
}