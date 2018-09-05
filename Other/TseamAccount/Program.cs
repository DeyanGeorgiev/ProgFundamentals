using System;
using System.Collections.Generic;
using System.Linq;

namespace TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dBase = Console.ReadLine().Split().ToList();


            string command = Console.ReadLine();


            while (command != "Play!")
            {
                List<string> commands = command.Split(' ', '-').ToList();

                switch (commands[0])
                {
                    case "Install":

                        dBase.Add(commands[1]);

                        break;

                    case "Uninstall":

                        dBase.Remove(commands[1]);

                        break;

                    case "Update":

                        for (int i = 0; i < dBase.Count; i++)
                        {
                            if (dBase[i].Equals(commands[1]))
                            {
                                dBase.RemoveAt(i);
                                dBase.Add(commands[1]);
                            }
                        }


                        break;

                    case "Expansion":

                        string expGame = commands[1] + ":" + commands[2];

                        for (int i = 0; i < dBase.Count; i++)
                        {
                            if (dBase[i].Equals(commands[1]))
                            {
                                dBase.Insert(i + 1, expGame);
                            }
                        }

                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", dBase));
        }
    }
}