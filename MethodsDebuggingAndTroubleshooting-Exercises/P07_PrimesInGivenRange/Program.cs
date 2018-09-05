using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace P07_PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum= int.Parse(Console.ReadLine());
            int secondNum= int.Parse(Console.ReadLine());



            String output = string.Join(", ", GetPrimesInRange(firstNum, secondNum).ToArray());
            Console.WriteLine(output);


        }


        static List<int> GetPrimesInRange(int firstNum, int secondNum)
        {
            List<int> primesInRange = new List<int>();

            if (firstNum == 0 || firstNum == 1 )
            {
                firstNum = 2;
            }
            
            for (int i = firstNum; i <= secondNum; i++)
                
            {
                
                bool isPrime=true;
                for(int j=2;j<=Math.Sqrt(i);j++)
                {
                    if(i%j==0)
                    {
                        isPrime=false;
                        break;
                    }
                }
                if(isPrime)
                {
                    primesInRange.Add(i);
                }
                        

                    
                }
            

            return primesInRange;
        }
    }
}