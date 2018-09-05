using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            
            File.Delete("output.txt");
            string[] words = File.ReadAllText("words.txt").Split();

            string[] textToCheck = File.ReadAllText("text.txt")
                    .ToLower()
                .Split(new char[] {'\n', '\r', ' ', '.', ',', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries)
                ;
            
            Dictionary<string, int> operations= new Dictionary<string, int>();


            foreach (string word in words)
            {
                operations.Add(word,0);
            }

            foreach (string w in textToCheck)
            {
                if (operations.ContainsKey(w))
                {
                    operations[w]++;
                }
                
            }

            foreach (var item in operations.OrderByDescending(x=> x.Value))
            {
                File.AppendAllText("output.txt", item.Key+" - "+item.Value+Environment.NewLine);
                
            }
        }
    }
}