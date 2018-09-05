using System;
using System.Linq;

namespace P11_EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int totalSum = 0;
            foreach (var number in inputArr)
            {
                totalSum += number;
            }


            int sumInLeft = 0;
            int sumInRight = totalSum;

            bool found = false;
            
            for (int i = 0; i < inputArr.Length; i++)
            {
                int curentSum = inputArr[i];
                sumInRight -= curentSum;

                if (sumInLeft == sumInRight)
                {

                   
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
                
                sumInLeft += curentSum;

            }
            
            if (found== false)
            {
                Console.WriteLine("no");
            }




        }
    }
}