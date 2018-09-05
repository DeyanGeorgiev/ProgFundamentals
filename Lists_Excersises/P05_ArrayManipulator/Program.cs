using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                List<string> operations = Console.ReadLine()
                    .Split()
                    .ToList();


//                string operative = operations[0];


//                switch (operative)
//                {
//                      case "print":
//                          Console.WriteLine("[{0}]", string.Join(", ", list));
//                          break;
//                    case "add":
//                        int indexAdd = int.Parse(operations[1]);
//                        int itemAdd = int.Parse(operations[2]);
//
//                        list.Insert(indexAdd, itemAdd);
//                        break;
//                    case 
//                        
//                }

                if (operations[0] == "print")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", list));
                    break;
                }

                if (operations[0] == "add")
                {
                    int indexAdd = int.Parse(operations[1]);
                    int itemAdd = int.Parse(operations[2]);

                    list.Insert(indexAdd, itemAdd);
                }

                else if (operations[0] == "addMany")
                {
                    operations.RemoveAt(0);
                    int indexMany = int.Parse(operations[0]);
                    operations.RemoveAt(0);

                    list.InsertRange(indexMany, AddMany(operations));
                }
                
                else if (operations[0] == "contains")
                {
                    int item = int.Parse(operations[1]);

                    int index = list.FindIndex(x => x == item);
                    Console.WriteLine(index);
                }
                
                else if (operations[0] == "remove")
                {
                    int remoItemAtIndex = int.Parse(operations[1]);
                    list.RemoveAt(remoItemAtIndex);
                }
                
                else if (operations[0] == "shift")
                {
                    int shiftPosition = int.Parse(operations[1]);

                    int item;
                    for (int i = 0; i < shiftPosition; i++)
                    {
                        item = list[i];
                        list.Remove(1);
                        list.Add(item);
                    }
                }
                
                else if (operations[0] == "sumPairs")
                {
                    int sum = 0;
                    for (int i = 0; i < list.Count-1; i++)
                    {
                        sum = list[i] + list[i + 1];
                        list.RemoveAt(i);
                        list.RemoveAt(i);
                        list.Insert(i,sum);
                        
                    }
                }
               

                
            }
        }

        private static List<int> AddMany(List<string> input)
        {
            List<int> output = input.Select(s => int.Parse(s)).ToList();

            return output;
        }
    }
}


// todo : use switch !