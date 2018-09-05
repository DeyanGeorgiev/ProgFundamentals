using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P07_QueryMess
{
    class Program
    {
        static void Main()
        {
            //Dictionary<string, List<string>> operative = new Dictionary<string, List<string>>();

            Dictionary<int, Dictionary<string, List<string>>> result =
                new Dictionary<int, Dictionary<string, List<string>>>();

            int dictCount = 0;

            while (true)
            {
                string input = Console.ReadLine();


                if (input != null && input.Equals("END"))
                {
                    foreach (var pair in result)
                    {
                        foreach (var inerPair in pair.Value)
                        {
                            Console.Write(inerPair.Key+"=["+string.Join(", ", inerPair.Value)+"]");
                        }

                        Console.WriteLine();
                    }

                    break;
                }


                List<string> inputManipulate = input
                    .Split('&', '?').ToList();

                for (int i = 0; i < inputManipulate.Count; i++)
                {
                    inputManipulate[i] = inputManipulate[i].Trim();
                    inputManipulate[i] = inputManipulate[i].Replace("%20", " ");
                    inputManipulate[i] = inputManipulate[i].Replace("+", " ");
                }

                var regex = "(?<key>.+[a-zA-Z0-9]+.+(?=[=]))=(?<value>(?<=[=]).+[a-zA-Z0-9]+.+)";
                
                result.Add(dictCount, new Dictionary<string, List<string>>());

                foreach (var item in inputManipulate)
                {
                    var match = Regex.Match(item, regex);

                    if (match.Success == false)
                    {
                        continue;
                    }

                    string key = match.Groups["key"].Value;
                    string value = match.Groups["value"].Value;

                    key = key.Trim();
                    value = value.Trim();

                    

                    if (result[dictCount].ContainsKey(key) == false)
                    {
                        result[dictCount].Add(key, new List<string>());
                    }

                    result[dictCount][key].Add(value);
                }


                dictCount++;
            }
        }
    }
}