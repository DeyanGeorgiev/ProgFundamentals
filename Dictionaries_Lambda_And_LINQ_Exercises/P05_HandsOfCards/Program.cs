using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace P05_HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            while (true)
            {
                string checkForJoker = Console.ReadLine();


                if (checkForJoker == "JOKER")
                    break;


                string[] input = checkForJoker
                    .Split(':')
                    .ToArray();
                string personName = input[0];

                List<string> cards = input[1]
                    .Trim()
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (dictionary.ContainsKey(personName) == false)
                {
                    dictionary.Add(personName, cards);
                }

                dictionary[personName].AddRange(cards);
            }

            Dictionary<string, int> powers = new Dictionary<string, int>();


            for (int i = 2; i <= 9; i++)
            {
                powers.Add(i.ToString(), i);
            }

            powers.Add("J", 11);
            powers.Add("Q", 12);
            powers.Add("K", 13);
            powers.Add("A", 14);
            powers.Add("D", 2);
            powers.Add("S", 4);
            powers.Add("H", 3);
            powers.Add("C", 1);
            powers.Add("10", 1);


            foreach (var player in dictionary)
            {
                var cards = player.Value.Distinct().ToList();



                int sum = 0;

                foreach (var card in cards)
                {
                    string cardPower = card[0].ToString();
                    string cardColor = card[card.Length - 1].ToString();

                    int cardPow = powers[cardPower];
                    int cardCol = powers[cardColor];

                    sum += cardPow * cardCol;
                }
            

            Console.WriteLine("{0}: {1}", player, sum);
            }
        }
    }
}