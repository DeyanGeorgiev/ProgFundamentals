using System;

namespace P12_NumChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            
                try
                {

                    int.Parse(Console.ReadLine());
                    Console.WriteLine("It is a number.");

                }
                catch (Exception )
                {

                    Console.WriteLine("Invalid input!");
                    
                }
            
        }
    }
}