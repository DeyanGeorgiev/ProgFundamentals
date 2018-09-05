using System;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
            
            int @base = int.Parse(input[0]);
            char[] num = input[1].ToCharArray();
 
            BigInteger result = new BigInteger(0);
 
            for (int i = 0; i < num.Length; i++)
            {
                int currentNum = (int)Char.GetNumericValue(num[i]);
                result += currentNum * BigInteger.Pow(@base, num.Length - i - 1);
                
               //1*7'1=7
                //3*7'0=10
                
                
            }
 
            Console.WriteLine(result);



            

        }
    }
}