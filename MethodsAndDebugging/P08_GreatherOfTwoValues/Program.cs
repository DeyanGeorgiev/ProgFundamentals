﻿using System;

namespace P08_GreatherOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var type= Console.ReadLine();

            if (type == "int")
            {
                int first= int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
                
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));
            }

            
        }

        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
                
            }
            
                return second;
            
        }

        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            
                return second;
            
        }

        static string GetMax(string first, string second)
        {
            if (String.Compare(first, second, StringComparison.Ordinal) >= 0)
            {
                return first;
            }

            return second;
        }
    }
}