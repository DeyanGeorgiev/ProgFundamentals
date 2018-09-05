using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list= Console.ReadLine().Split().Select(int.Parse).ToList();
            
            List<int> extracted= new List<int>();


            foreach (var number in list)
            {
                if (Math.Sqrt(number) == (int) Math.Sqrt(number))
                {
                    extracted.Add(number);
                    
                }
            }

            extracted.Sort((x,y) => y.CompareTo(x) );

            Console.WriteLine(string.Join(" ", extracted));
        }
    }
}