using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace P07_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] operations = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int item = operations[0];
            int power = operations[1];

            int bombIndex = list.IndexOf(item);

            while (bombIndex != -1)
            {
                int leftIndex = bombIndex - power;
                int rightIndex = bombIndex + power;

                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }

                if (rightIndex > list.Count - 1)
                {
                    rightIndex = list.Count - 1;
                }

                int count = rightIndex - leftIndex+ 1;
                
                list.RemoveRange(leftIndex, count);

                bombIndex = list.IndexOf(item);
            }

            

            Console.WriteLine(list.Sum());

        }
    }
}