using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string operations = input[0];


                if (operations == "END")
                {
                    break;
                }

                switch (operations)
                {
                    case "A":

                        if (phonebook.ContainsKey(input[1]))
                        {
                            phonebook[input[1]] = input[2];
                        }
                        else
                        {
                            phonebook.Add(input[1], input[2]);
                        }


                        break;

                    case "S":

                        if (phonebook.ContainsKey(input[1]))
                        {
                            Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }

                        break;
                }
            }
        }
    }
}