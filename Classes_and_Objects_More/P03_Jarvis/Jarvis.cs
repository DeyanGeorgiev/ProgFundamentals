using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace P03_Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long maxEnergy = long.Parse(input);

            Dictionary<string, Dictionary<int, List<dynamic>>> dataBase = new Dictionary<string, Dictionary<int, List<dynamic>>>();

            while (true)
            {
                if (input.Equals("Assemble!"))
                {
                    foreach (var item in dataBase)
                    {
                        foreach (var VARIABLE in COLLECTION)
                        {
                            
                        }
                    }
                    break;
                }

                string[] data = Console.ReadLine()
                    .Split();

                string typeOfComponent = data[0];
                int energyConsumption = int.Parse(data[1]);
                int property1 = int.Parse(data[2]);
                
                
                string material = data[3];
                int property2 = 0;
                try
                {
                     property2 = int.Parse(data[3]);
                }
                catch
                {
                    char[] toConvert = data[3].ToCharArray();
                    

                    for (int i = 0; i < toConvert.Length; i++)
                    {
                        property2 += toConvert[i];
                    }
                }

                if (typeOfComponent.Equals("Head"))
                {
                    Head head = new Head(energyConsumption,property1,material);
                }
                else if (typeOfComponent.Equals("Arms"))
                {
                    Arms arms= new Arms(energyConsumption,property1,property2);
                }
                else if (typeOfComponent.Equals("Legs"))
                {
                    Legs legs = new Legs(energyConsumption,property1, property2);
                }
                else if (typeOfComponent.Equals("Torso"))
                {
                    Torso torso= new Torso(energyConsumption, property1,material);
                    
                    
                }

              
                

                
            }
        }
    }
}