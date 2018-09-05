using System;
using  System.Linq;

namespace P02_ReverseArrayOfIntegers
{
    class Program
    {
         static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            
            int[] arrForReverse= new int[input];

            for (int i = 0; i < input; i++)
            {
                arrForReverse[i]= int.Parse(Console.ReadLine());
                
               
            }
            
            Array.Reverse(arrForReverse);
            Console.WriteLine(string.Join(" ", arrForReverse));

           
            
           
        }
    }
}