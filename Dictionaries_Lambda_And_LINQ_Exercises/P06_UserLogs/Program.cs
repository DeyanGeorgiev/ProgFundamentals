using System;
using System.Collections.Generic;
using System.Linq;


namespace P06_UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> dictionary =
                new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                    break;

                string[] inRawData = input
                    .Split()
                    .ToArray();

                string ip = inRawData[0].Replace("IP=", "");
                string rawMess = inRawData[1].Trim().Substring(0, 1).Replace("m", "1");
                int mess = int.Parse(rawMess);
                string user = inRawData[2].Replace("user=", "");


                if (dictionary.ContainsKey(user) == false)
                {
                    dictionary.Add(user, new Dictionary<string, int>());
                    dictionary[user].Add(ip, mess);
                }
                else
                {
                    if (dictionary[user].ContainsKey(ip) == false)
                    {
                        dictionary[user].Add(ip, mess);
                    }
                    else
                    {
                        dictionary[user][ip] += mess;
                    }
                }
            }


            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0}:", pair.Key);

                string line = "";

                foreach (var innerPair in pair.Value)
                {
                    line += innerPair.Key + " => " + innerPair.Value + ", ";
                }

                line = line.Substring(0, line.Length - 2);
                line += ".";

                Console.WriteLine(line);
            }
        }
    }
}