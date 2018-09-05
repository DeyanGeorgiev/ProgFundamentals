using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            Dictionary<string, string> filenameExtension = new Dictionary<string, string>();

            Dictionary<string, long> extensionSize = new Dictionary<string, long>();

            string extension = "";

            for (int i = 0; i < input; i++)
            {
                List<string> filePath = Console.ReadLine()
                    ?.Split(new[] {'\\', ';'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string root = filePath[0];

                filePath.Reverse();

                var size = long.Parse(filePath[0]);
                extension = filePath[1];


                if (extensionSize.ContainsKey(extension) == false)
                {
                    extensionSize.Add(extension, size);
                    filenameExtension.Add(extension, root);
                }

                extensionSize[extension] = size;
            }


            string regex = "(?<=\\.)[a-z]+";


            string[] secInput = Console.ReadLine().Split();

            string searchRoot = secInput[2];
            string searchFile = secInput[0];

            


            int counter = 0;
            

            foreach (var item in extensionSize.OrderByDescending(x=>x.Value).ThenBy(y=> y.Key.Length))
            {
                var match = Regex.Match(item.Key, regex);
                var havEquals = match.Value.Equals(searchFile);
                
                var value = filenameExtension[item.Key];

                if (filenameExtension.ContainsKey(searchRoot) && havEquals )
                {
                   
                   

                    
                    Console.WriteLine($"{item.Key} - {value} KB");
                    counter++;
                }
                
                
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}