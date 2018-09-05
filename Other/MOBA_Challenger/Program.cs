using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> dBase = new Dictionary<string, Dictionary<string, int>>();


            while (input != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    string[] operations = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);


                    if (dBase.ContainsKey(operations[0]) == false)
                    {
                        dBase.Add(operations[0], new Dictionary<string, int>());
                    }


                    if (dBase[operations[0]].ContainsKey(operations[1]))
                    {
                        if (dBase[operations[0]][operations[1]] < int.Parse(operations[2]))
                        {
                            dBase[operations[0]][operations[1]] = int.Parse(operations[2]);
                        }
                    }
                    else
                    {
                        dBase[operations[0]].Add(operations[1], int.Parse(operations[2]));
                    }
                }

                if (input.Contains(" vs "))
                {
                    string[] pVsP = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

                    string player1 = pVsP[0];
                    string player2 = pVsP[1];

                    if (dBase.ContainsKey(player1) && dBase.ContainsKey(player2))
                    {
                        foreach (var one in dBase[player1])
                        {
                            foreach (var two in dBase[player2])
                            {
                                if (one.Key == two.Key)
                                {
                                    if (dBase[player1].Values.Sum() > dBase[player2].Values.Sum())
                                    {
                                        dBase.Remove(player2);
                                    }
                                    else if (dBase[player1].Values.Sum() < dBase[player2].Values.Sum())
                                    {
                                        dBase.Remove(player1);
                                    }
                                }
                            }
                        }
                    }
                }


                input = Console.ReadLine();
                Console.WriteLine();
            }

            foreach (var outerD in dBase.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(i => i.Key))

            {
                var sumKvp = outerD.Value.Values.Sum(i => i).ToString();

                Console.WriteLine($"{outerD.Key}: {sumKvp} skill");

                foreach (var inerD in outerD.Value.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine($"- {inerD.Key} <::> {inerD.Value}");
                }
            }
        }
    }
}