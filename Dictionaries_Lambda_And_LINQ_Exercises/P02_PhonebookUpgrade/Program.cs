using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();
                
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

                    case "ListAll":

                        foreach (KeyValuePair<string, string> contact in phonebook)
                        {
                            Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                        }

                        break;
                }
            }
        }
    }
}