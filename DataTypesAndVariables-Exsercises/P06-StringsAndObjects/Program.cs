using System;

namespace P06_StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";


            Object word = first + " " + second;

            string third = (string) word;


            Console.WriteLine(third);



        }
        
       
    }
}