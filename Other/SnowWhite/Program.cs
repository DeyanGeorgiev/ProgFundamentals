using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> dBase = new Dictionary<string, Dictionary<string, int>>();
            
            while (input != "Once upon a time")
            {
                string[] nextInput = input.Split(new[] {"<:>"}, StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = nextInput[0];
                string dwarfHatColor = nextInput[1];
                int dwarfPhysics = int.Parse(nextInput[2]);


                if (dBase.ContainsKey(dwarfName) == false)
                {
                    dBase.Add(dwarfName, new Dictionary<string, int>());
                }


                if (dBase[dwarfName].ContainsKey(dwarfHatColor))
                {
                    dBase[dwarfName][dwarfHatColor] = dwarfPhysics;
                }
                else
                {
                    dBase[dwarfName].Add(dwarfHatColor, dwarfPhysics);
                }


                input = Console.ReadLine();
            }



            


            foreach (var item in dBase.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Count()))
            {
                foreach (var inner in item.Value)
                {
                    Console.WriteLine($"({inner.Key}) {item.Key} <-> {inner.Value}");
                }

                Console.WriteLine();
            }
        }
    }
}