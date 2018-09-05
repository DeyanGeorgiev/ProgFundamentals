using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int index = int.Parse(Console.ReadLine());

            int totalSum = 0;

            while (list.Count > 0)
            {
                
                
                
                if (index < 0)
                {
                    totalSum += list[0];
                    list.RemoveAt(0);

                    int getItem = list[list.Count - 1];
                    list.Insert(0, getItem);

                    list.RemoveAt(list.Count - 1);
                }

                else if (index > list.Count - 1)
                {
                    totalSum += list.Count - 1;

                    list.RemoveAt(list.Count - 1);

                    int getItem = list[0];
                    list.Insert(list.Count, getItem);

                    list.RemoveAt(0);
                }

                else
                {

                    int element = list[index];
                    totalSum += element;

                    list.RemoveAt(index);



                    for (int i = 0; i < list.Count; i++)
                    {
                        if (element <= list[i])
                        {
                            list[i] = list[i] - element;
                        }
                        else
                        {
                            list[i] = list[i] + element;
                        }
                    }
                }
                


                index = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(totalSum);
        }
    }
}