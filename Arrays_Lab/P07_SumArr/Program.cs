using System;
using System.Linq;

namespace P07_SumArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // get max lenght

            int maxLenght = Math.Max(firstArr.Length , secondArr.Length);

            for (int i = 0, j= 0; i < maxLenght; i++, j++)
            {
                var sum = firstArr[i % firstArr.Length] + secondArr[j % secondArr.Length];

                Console.Write(sum+ " ");
                
            }
            
            
        }
        
        
        

       
        
        
    }
}