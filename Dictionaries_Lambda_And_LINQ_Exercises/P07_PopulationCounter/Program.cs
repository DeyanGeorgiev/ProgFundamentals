using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace P07_PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> totalPopulations = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> citiesAndCountries =
                new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "report")
                    break;


                string[] getData = input
                    .Split("|")
                    .ToArray();

                string city = getData[0].ToString();
                string country = getData[1].ToString();
                long population = long.Parse(getData[2]);

                if (citiesAndCountries.ContainsKey(country) == false)
                {
                    totalPopulations.Add(country, 0);
                    citiesAndCountries.Add(country, new Dictionary<string, long>());
                }

                totalPopulations[country] += population;
                citiesAndCountries[country].Add(city, population);
            }

            foreach (var countr in totalPopulations.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"{countr.Key} (total population: {countr.Value})");
                    
                    Dictionary<string, long> cities = citiesAndCountries[countr.Key].OrderByDescending(c => c.Value)
                        .ToDictionary(x => x.Key, y => y.Value);


                    foreach (var item in cities)
                    {
                        Console.WriteLine($"=>{item.Key}: {item.Value}");
                    }
                }
            }
        }
    }
