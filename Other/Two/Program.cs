using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();



       
        while (true)
        {
            int[] data = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            
            if (input=="end")
            {
                Console.WriteLine(string.Join(" ", data));
                break;
            }
            
            
                List<string> operative = input
                    .Split()
                    .ToList();


                switch (operative[0])
                {
                    case "reverse":
                        int start = int.Parse(operative[2]);
                        int end = int.Parse(operative[4]);

                        if (start > data.Length || start < 0 || end < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }

                        Array.Reverse(data, start, end);

                        break;

                    case "rollLeft":

                        int countL = Convert.ToInt32(operative[1]);

                        if (countL > data.Length || countL < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }


                        for (int i = 0; i < countL; i++)
                        {
                            data = ShiftLeft(data).ToArray();
                        }

                        break;

                    case "sort":
                        int startSort = int.Parse(operative[2]);
                        int endSort = int.Parse(operative[4]);

                        if (startSort > data.Length || startSort < 0 || endSort < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }

                        Array.Sort(data, startSort, endSort);

                        break;

                    case "rollRight":


                        int countR = Convert.ToInt32(operative[1]);

                        if (countR > data.Length || countR < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }


                        for (int i = 0; i < countR; i++)
                        {
                            data = ShiftRight(data).ToArray();
                        }

                        break;
                }
            
        }

        
    }

    public static int[] ShiftLeft(int[] arr)
    {
        int[] demo = new int[arr.Length];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            demo[i] = arr[i + 1];
        }

        demo[demo.Length - 1] = arr[0];

        return demo;
    }

    public static int[] ShiftRight(int[] arr)
    {
        int[] demo = new int[arr.Length];

        for (int i = 1; i < arr.Length; i++)
        {
            demo[i] = arr[i - 1];
        }

        demo[0] = arr[demo.Length - 1];

        return demo;
    }
}