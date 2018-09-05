using System;
using System.Collections.Generic;
using System.Linq;

namespace Two
{
    class Program
    {
        static void Main()
        {
            List<string> dBase = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                List<string> operstions = input.Split(":").ToList();

                string command = operstions[0];


                switch (command)
                {
                    case "Add":


                        dBase.Add(operstions[1]);

                        break;

                    case "Insert":

                        if (dBase.Contains(operstions[1])== false )
                        {
                            dBase.Insert(int.Parse(operstions[2]), operstions[1]);
                        }
                        

                        break;

                    case "Remove":

                        dBase.Remove(operstions[1]);

                        break;

                    case "Swap":

                        string position1 = operstions[1];
                        string position2 = operstions[2];

                         if (dBase.Contains(position1) && dBase.Contains(position2))
                        {
                            var p1Index = int.Parse(dBase.IndexOf(position1).ToString());
                            var p2Index = int.Parse(dBase.IndexOf(position2).ToString());

                            dBase.Remove(position1);
                            dBase.Remove(position2);

                            dBase.Insert(p1Index, position2);
                            dBase.Insert(p2Index, position1);
                        }
                         if (dBase.Contains(position1 + "-Exercise") && dBase.Contains(position2))
                        {
                            var p1Index = int.Parse(dBase.IndexOf(position1 + "-Exercise").ToString());
                            var p2Index = int.Parse(dBase.IndexOf(position2).ToString());

                            dBase.Remove(position1 + "-Exercise");
                            dBase.Remove(position2);

                            dBase.Insert(p1Index, position2);
                            dBase.Insert(p2Index, position1 + "-Exercise");
                        }
                       if (dBase.Contains(position1) && dBase.Contains(position2 + "-Exercise"))
                        {
                            var p1Index = int.Parse(dBase.IndexOf(position1).ToString());
                            var p2Index = int.Parse(dBase.IndexOf(position2 + "-Exercise").ToString());

                            dBase.Remove(position1);
                            dBase.Remove(position2 + "-Exercise");

                            dBase.Insert(p1Index, position2 + "-Exercise");
                            dBase.Insert(p2Index, position1);
                        }
                         if (dBase.Contains(position1 + "-Exercise") && dBase.Contains(position2 + "-Exercise"))
                        {
                            var p1Index = int.Parse(dBase.IndexOf(position1 + "-Exercise").ToString());
                            var p2Index = int.Parse(dBase.IndexOf(position2 + "-Exercise").ToString());

                            dBase.Remove(position1 + "-Exercise");
                            dBase.Remove(position2 + "-Exercise");

                            dBase.Insert(p1Index, position2 + "-Exercise");
                            dBase.Insert(p2Index, position1 + "-Exercise");
                        }
                        

                        break;

                    case "Exercise":

                        string replacable = operstions[1] + "-Exercise";

                        if (dBase.Contains(operstions[1]))
                        {
                            // take position 
                            var pndex = int.Parse(dBase.IndexOf(operstions[1]).ToString());

                            dBase.RemoveAt(pndex);
                            dBase.Insert(pndex, replacable);
                        }
                        else
                        {
                            dBase.Add(operstions[1]);
                            dBase.Add(replacable);
                        }

                        break;
                }

                input = Console.ReadLine();
            }


            int i = 1;
            foreach (var item in dBase)
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }
        }
    }
}