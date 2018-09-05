using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<double, string>> list =
                new Dictionary<string, KeyValuePair<double, string>>();
            
            Regex regex = new Regex(@"(?<num>[A-Z]{2})(?<digits>\d+.\d+)(?<wheter>[A-Za-z]+)\|");

            

            while (true)
            {
                string input = Console.ReadLine();

                while (input.Equals("end"))
                {
                    foreach (var item in list.OrderBy(d => d.Value.Key))
                    {
                        Console.WriteLine($"{item.Key}=> {item.Value.Key:f2}=> {item.Value.Value}");
                    }
                    break;
                }



                MatchCollection matches = regex.Matches(input);


                foreach (Match match in matches)
                {
                    string num = match.Groups["num"].Value;
                    double digits = double.Parse(match.Groups["digits"].Value);
                    string wheater = match.Groups["wheter"].Value;


                    if (list.ContainsKey(num) == false)
                    {
                        list.Add(num, new KeyValuePair<double, string>(digits, wheater));
                    }

                    else
                    {
                        list[num] = new KeyValuePair<double, string>(digits, wheater);
                    }
                }
            }

            
            }
        }
    }
