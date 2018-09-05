using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToList();


          
            int bestStart = 0;
            int bestCount = 0;
            int count = 1;
            
            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    count++;

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestStart = inputList[i];
                    }
                }
                else
                {
                    count = 1;
                    inputList[i] = inputList[i + 1];
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write("{0} ", bestStart);
            }
        }
    }
}

// todo: need check