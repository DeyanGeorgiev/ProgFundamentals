using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                string mail = Console.ReadLine();


                if (name == "stop")
                {
                    foreach (var data in dictionary.ToList())
                    {
                        if (data.Value.EndsWith(".us") || data.Value.EndsWith(".uk"))
                        {
                            dictionary.Remove(data.Key);
                        }
                        else

                        {
                            Console.WriteLine("{0} -> {1}", data.Key, data.Value);
                        }
                    }


                    break;
                }

                if (dictionary.ContainsKey(name) == false)
                {
                    dictionary.Add(name, mail);
                }
                else
                {
                    dictionary[name] = mail;
                }
            }
        }
    }
}