using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace P04_SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args )
        {
            List<int> list= Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            int sum = 0;

            for (int i = 0; i < list.Count-1; )
            {


                if (list[i] == list[i + 1])
                {
                    
                    sum = list[i] + list[i + 1];
                    list.RemoveAt(i+1);
                    list.RemoveAt(i);
                    list.Insert(i,sum);
                    i = 0;

                }
                else
                {
                    i++;
                }
                

            }
                
            

            Console.WriteLine(string.Join(" ", list));
        }
    }
}