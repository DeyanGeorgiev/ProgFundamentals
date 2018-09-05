using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05_ParkingValidation
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Dictionary<string, string> registered = new Dictionary<string, string>();

            var regex = "\\b[A-Z]{2}[0-9]{4}[A-Z]{2}\\b";

            for (int i = 0; i < input; i++)
            {
                List<string> comingInfo = Console.ReadLine()?.Split().ToList();


                if (comingInfo != null)
                {
                    string command = comingInfo[0];
                    string user = comingInfo[1];
                    string plate = "";
                    try
                    {
                        plate = comingInfo[2];
                    }
                    catch
                    {
                        // ignored
                    }


                    if (command.Equals("register"))
                    {
                        Match match = Regex.Match(plate, regex);

                        if (match.Success == false)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {plate}");
                            continue;
                        }

                        if (match.Value == plate && registered.ContainsValue(plate))
                        {
                            Console.WriteLine($"ERROR: license plate {plate} is busy");
                            continue;
                        }


                        if (registered.ContainsKey(user) == false)
                        {
                            registered.Add(user, plate);
                            Console.WriteLine($"{user} registered {plate} successfully");
                        }
                    }


                    if (command.Equals("unregister"))
                    {
                        if (registered.ContainsKey(user) == false)
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }

                        else
                        {
                            registered.Remove(user);
                            Console.WriteLine($"user {user} unregistered successfully");
                        }
                    }
                }
            }

            if (registered.Count != 0)
            {
                foreach (var item in registered)
                {
                    Console.WriteLine($"{item.Key} => {item.Value}");
                }
            }
        }
    }
}