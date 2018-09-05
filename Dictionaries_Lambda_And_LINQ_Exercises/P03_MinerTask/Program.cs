using System;
using System.Collections.Generic;

namespace P03_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

          

            while (true)
            {
                string resource = Console.ReadLine();
                
                if (resource == "stop")
                {
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value );
                    }
                    
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());
                
                if (dictionary.ContainsKey(resource))
                {
                    dictionary[resource] += quantity;
                    
                }
                else
                {
                    dictionary.Add(resource, quantity);
                }


                
                
                
            }
        }
    }
}