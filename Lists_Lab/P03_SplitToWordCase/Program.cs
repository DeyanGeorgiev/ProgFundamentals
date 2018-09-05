using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_SplitToWordCase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ; : . ! ( ) \" \' \\ / [ ] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> listLower = new List<string>();
            List<string> listUpper = new List<string>();
            List<string> listMix = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i];

                if (IsLower(word))
                {
                    listLower.Add(word);
                }
                else if (IsUpper(word))
                {
                    listUpper.Add(word);
                }
                else
                {
                    listMix.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", listLower));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", listMix));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", listUpper));
        }

        private static bool IsLower(string word)
        {
            foreach (char character in word)
            {
                if (character < 'a' || character > 'z')
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsUpper(string word)
        {
            foreach (char character in word)
            {
                if (character < 'A' || character > 'Z')
                {
                    return false;
                }
            }

            return true;
        }
    }
}