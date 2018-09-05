using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list= Console.ReadLine().Split().Select(double.Parse).ToList();
            
            SortedDictionary<double, int> dictionary= new SortedDictionary<double, int>();


            int count = 1;
            foreach (var num in list)
            {
                if (dictionary.ContainsKey(num) == false)
                {
                    dictionary.Add(num, count);
                }
                else
                {
                    dictionary[num]++;
                }
                
                
            }

            foreach (var num in dictionary.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, dictionary[num]);
            }

            
            
                
        }
    }
}