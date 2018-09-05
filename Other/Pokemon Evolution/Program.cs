using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, List<int>>> dBase =
                new Dictionary<string, Dictionary<string, List<int>>>();

            while (input != "wubbalubbadubdub")
            {
                if (input.Contains(" -> "))
                {
                    string[] array = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string pokemonName = array[0];
                    string evolutionType = array[1];
                    int evolutionIndex = int.Parse(array[2]);

                    if (dBase.ContainsKey(pokemonName) == false)
                    {
                        dBase.Add(pokemonName, new Dictionary<string, List<int>>());
                    }

                    if (dBase[pokemonName].ContainsKey(evolutionType) == false)
                    {
                        dBase[pokemonName].Add(evolutionType, new List<int>());
                        dBase[pokemonName][evolutionType].Add(evolutionIndex);
                    }
                    else
                    {
                        dBase[pokemonName][evolutionType].Add(evolutionIndex);
                    }
                }

                else
                {
                    string pokemonName = input;

                    if (dBase.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");

                        foreach (var kvp in dBase[pokemonName])
                        {
                            foreach (var val in kvp.Value)
                            {
                                Console.WriteLine($"{kvp.Key} <-> {val}");
                            }
                        }
                    }
                }


                input = Console.ReadLine();
            }


            foreach (var kvp in dBase)
            {
                Console.WriteLine($"# {kvp.Key}");

                foreach (var inside in kvp.Value.OrderByDescending(v=> v.Value.Max()))
                {
                    
                    foreach (var val in inside.Value)
                    {
                        Console.WriteLine($"{inside.Key} <-> {val}");
                    }
                }
            }
        }
    }
}