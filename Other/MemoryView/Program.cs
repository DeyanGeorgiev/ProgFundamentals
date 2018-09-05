using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder builder = new StringBuilder();

            List<string> result = new List<string>();

            while (input != "Visual Studio crash")
            {
                builder.Append(input+" ");

                input = Console.ReadLine();
            }

            string all = builder.ToString();

            string[] arr = all.Split();


            for (int i = 0; i < arr.Length-4; i++)
            {
                if (arr[i] == "32656" && arr[i + 1] == "19759" && arr[i + 2] == "32763" && arr[i + 3] == "0")
                {
                    int numberLenghtWord = int.Parse(arr[i + 4]);

                    string worLd = "";
                    for (int j = i+6; j <= i+6+numberLenghtWord; j++)
                    {
                        char word =  Convert.ToChar(int.Parse(arr[j]));

                        worLd += word;
                        
                    }
                    
                    result.Add(worLd);
                    
                    
                }
            }
            
            
            
            
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}