using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace P08_LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            SortedDictionary<string, Dictionary<string, int>> dictionary =
                new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < input; i++)
            {
                string[] arrInput = Console.ReadLine()
                    .Split()
                    .ToArray();

                string ip = arrInput[0];
                string userName = arrInput[1];
                int timeCount = int.Parse(arrInput[2]);


                if (dictionary.ContainsKey(userName) == false)
                {
                    dictionary.Add(userName, new Dictionary<string, int>());
                    dictionary[userName].Add(ip, timeCount);
                }
                else
                {
                    if (dictionary[userName].ContainsKey(ip))
                    {
                        dictionary[userName][ip] += timeCount;
                    }
                    else
                    {
                        dictionary[userName].Add(ip, timeCount);
                    }
                }
            }

            foreach (var pair in dictionary)
            {
                var sum = 0;

                List<string> totalIp = new List<string>();
                var listIp= totalIp.OrderBy(x => x);

                foreach (var innerPair in pair.Value)
                {
                    sum += innerPair.Value;
                    totalIp.Add(innerPair.Key);
                }

                Console.WriteLine($"{pair.Key}: {sum} [{String.Join(", ", listIp)}]");
            }
        }
    }
}