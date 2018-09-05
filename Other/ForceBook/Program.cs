using System;
using System.Collections.Generic;
using System.Linq;


namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Dictionary<string, int> sideQtyMembers = new Dictionary<string, int>();
            Dictionary<string, List<string>> sideUsers = new Dictionary<string, List<string>>();


            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string[] sideUser = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                    string side = sideUser[0];
                    string user = sideUser[1];

                    if (sideUsers.ContainsKey(side) == false)
                    {
                        sideUsers.Add(side, new List<string>());
                        sideUsers[side].Add(user);
                        sideQtyMembers.Add(side, 1);
                    }
                    else
                    {
                        foreach (var kvp in sideUsers)
                        {
                            if (kvp.Value.Contains(user))
                            {
                                continue;
                            }

                            sideUsers[side].Add(user);
                            sideQtyMembers[side]++;
                        }
                    }
                }

                if (input.Contains(" -> "))
                {
                    string[] userSide = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string user = userSide[0];
                    string side = userSide[1];


                    foreach (var kvp in sideUsers)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            kvp.Value.Remove(user);
                        }
                    }


                    if (sideQtyMembers.ContainsKey(side))
                    {
                        sideQtyMembers[side]++;
                        sideUsers[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        sideQtyMembers.Add(side, 1);
                        sideUsers.Add(side, new List<string>());
                        sideUsers[side].Add(user);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in sideUsers.OrderBy(x => x.Key))

            {
                if (kvp.Value.Count == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Side: {kvp.Key}, Members: {sideQtyMembers[kvp.Key]}");
                    foreach (var val in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine("! {0}", val);
                    }
                }
            }
        }
    }
}