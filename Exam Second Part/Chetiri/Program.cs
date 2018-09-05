using System;
using System.Collections.Generic;
using System.Linq;

namespace Chetiri
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namePoints = new Dictionary<string, int>();
            Dictionary<string, int> languageCount = new Dictionary<string, int>();

            string input = Console.ReadLine();


            while (input != "exam finished")
            {
                List<string> operation = input.Split("-").ToList();

                string username = operation[0];
                string language = operation[1];
                int points = 0;
                try
                {
                     points = int.Parse(operation[2]);
                }
                catch
                {
                }


                if (operation[1].Contains("banned") && namePoints.ContainsKey(operation[0]))
                {
                    namePoints.Remove(operation[0]);
                }


                if (namePoints.ContainsKey(username) == false && operation[0].Contains("banned")== false)
                {
                    namePoints.Add(username, 0);

                    try
                    {
                        languageCount.Add(language, 0);
                    }
                    catch
                    {
                        languageCount[language] += 0;
                    }
                }

                languageCount[language] += 1;
                namePoints[username] = points;


                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            
            foreach (var names in namePoints.OrderByDescending(y=> y.Value).ThenBy(x=> x.Key))
            {
                if (names.Value.Equals(0))
                {
                    continue;
                }
              
                    Console.WriteLine($"{names.Key} | {names.Value}");
                
            }

            Console.WriteLine("Submissions:");

            foreach (var lang in languageCount.OrderByDescending(x=> x.Value).ThenBy(y=> y.Key))
            {
                if (lang.Key.Equals("banned"))
                {
                    continue;
                }
                
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}