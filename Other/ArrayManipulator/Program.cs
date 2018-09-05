using System;
using System.Collections.Generic;
using System.Linq;


namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrToManipulate = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();


            while (input != "end")
            {
                List<string> commingData = input.Split().ToList();

                string command = commingData[0];

                switch (command)
                {
                    case "exchange":

                        int index = int.Parse(commingData[1]);

                        if (index > arrToManipulate.Length)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            arrToManipulate = ShiftLeft(arrToManipulate).ToArray();
                        }

                        input = Console.ReadLine();

                        break;

                    case "max":

                        if (commingData[1] == "odd")
                        {
                            try
                            {
                                Console.WriteLine($"{MaxOdd(arrToManipulate)}");
                            }
                            catch 
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                        }

                        if (commingData[1] == "even")
                        {
                            try
                            {
                                Console.WriteLine($"{MaxEven(arrToManipulate)}");
                            }
                            catch 
                            {
                                Console.WriteLine("No matches");
                                break;
                            }
                        }

                        break;

                    case "min":
                        if (commingData[1] == "odd")
                        {
                            try
                            {
                                Console.WriteLine($"{MinOdd(arrToManipulate)}");
                            }
                            catch 
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                        }

                        else if (commingData[1] == "even")
                        {
                            try
                            {
                                Console.WriteLine($"{MinEven(arrToManipulate)}");
                            }
                            catch 
                            {
                                Console.WriteLine("No matches");
                                continue;
                            }
                        }


                        input = Console.ReadLine();
                        break;

                    case "first":
                        int counter = int.Parse(commingData[1]);
                        string whatToCheck = commingData[2];

                        if (counter > arrToManipulate.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }

                        if (whatToCheck == "odd")

                            try
                            {
                                Console.WriteLine($"{FirstCountOdd(arrToManipulate, counter)}");
                            }
                            catch 
                            {
                                Console.WriteLine("[]");
                                continue;
                            }

                        if (whatToCheck == "even")

                            try
                            {
                                Console.WriteLine($"{FirstCountEven(arrToManipulate, counter)}");
                            }
                            catch 
                            {
                                Console.WriteLine("[]");
                                continue;
                            }

                        input = Console.ReadLine();
                        break;

                    case "last":
                        int count = int.Parse(commingData[1]);
                        string toCheck = commingData[2];

                        if (count > arrToManipulate.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }

                        if (toCheck == "odd")

                            try
                            {
                                Console.WriteLine($"{LastCountOdd(arrToManipulate, count)}");
                            }
                            catch 
                            {
                                Console.WriteLine("[]");
                                continue;
                            }

                        if (toCheck == "even")

                            try
                            {
                                Console.WriteLine($"{LastCountEven(arrToManipulate, count)}");
                            }
                            catch 
                            {
                                Console.WriteLine("[]");
                                continue;
                            }

                        input = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("["+string.Join(", ", arrToManipulate)+"]");
        }

        private static List<int> LastCountOdd(int[] arr, int count)
        {
            List<int> result = new List<int>();
            int myCount = 1;

            while (count <= myCount)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        continue;
                    }

                    result.Add(arr[i]);
                    myCount++;
                }
            }

            return result;
        }

        private static List<int> LastCountEven(int[] arr, int count)
        {
            List<int> result = new List<int>();
            int myCount = 1;

            while (count <= myCount)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }

                    result.Add(arr[i]);
                    myCount++;
                }
            }

            return result;
        }

        private static List<int> FirstCountEven(int[] arr, int count)
        {
            List<int> result = new List<int>();
            int myCount = 1;

            while (count <= myCount)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }

                    result.Add(arr[i]);
                    myCount++;
                }
            }

            return result;
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


        public static int MaxOdd(int[] arr)
        {
            var demo = arr.Where(x => x % 2 == 0).Max();

            return demo;
        }

        public static int MaxEven(int[] arr)
        {
            var demo = arr.Where(x => x % 2 != 0).Max();

            return demo;
        }

        public static int MinOdd(int[] arr)
        {
            var demo = arr.Where(x => x % 2 != 0).Min();

            return demo;
        }

        public static int MinEven(int[] arr)
        {
            var demo = arr.Where(x => x % 2 == 0).Min();

            return demo;
        }

        public static List<int> FirstCountOdd(int[] arr, int count)
        {
            List<int> result = new List<int>();
            int myCount = 1;

            while (count <= myCount)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }

                    result.Add(arr[i]);
                    myCount++;
                }
            }

            return result;
        }
    }
}