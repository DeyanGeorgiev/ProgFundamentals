using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            

            while (true)
            {
                
                string input = Console.ReadLine();
                string[] operation = input.Split().ToArray();
                
                if (operation[0] == "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    
                    {
                        if (list[i] % 2 == 0)
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                    }

                    Console.WriteLine(string.Join(" ", list));
                    break;
                }

                if (operation[0] == "Even")
                {
                    for (int i = 0; i < list.Count; i++)
                    
                    {
                        if (list[i] % 2 != 0)
                        {
                            list.Remove(list[i]);
                            i--;
                        }
                    }

                    Console.WriteLine(string.Join(" ", list));
                    break;
                }

                if (operation[0] == "Delete")
                {
                    int num = int.Parse(operation[1]);
                    list.RemoveAll(item => item == num);
                }

                if (operation[0] == "Insert")
                {
                    int element = int.Parse(operation[1]);
                    int position = int.Parse(operation[2]);

                    list.Insert(position, element);
                }
            }
        }
    }
}