using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace P09_Srubsko
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr= new string[2];
                try
                {
                    arr = Console.ReadLine()
                        .Split()
                        .ToArray();

                }
                catch (Exception e)
                {
                    
                }

            Console.WriteLine();
        }
    }
}

// todo: need fill