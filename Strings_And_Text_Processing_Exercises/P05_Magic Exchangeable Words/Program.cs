using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace P05_Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();

            string[] input = Console.ReadLine().Split();
            string one = input[0];
            string two = input[1];

            int minL = Math.Min(input[0].Length, input[1].Length);
            bool isExchangeable = true;

            for (int i = 0; i < minL; i++)
            {
                if (dict.ContainsKey(one[i])==false)
                {
                    if (dict.ContainsValue(two[i])== false)
                    {
                        dict.Add(one[i], two[i]);
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }

                }
                else
                {
                    if (dict[one[i]] != two[i])
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            StringBuilder builder = new StringBuilder();

            if (one.Length > two.Length)
            {
                builder.Append(one.Substring(minL));
            }
            else
            {
                builder.Append(two.Substring(minL));
            }

            string rest = builder.ToString();
            
            foreach (char chara in rest)
            {
                if (!dict.ContainsValue(chara) && !dict.ContainsKey(chara))
                {
                    isExchangeable = false;
                }
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}