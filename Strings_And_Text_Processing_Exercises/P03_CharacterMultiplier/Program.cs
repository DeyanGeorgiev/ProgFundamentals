using System;


namespace P03_CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string wordOne = input[0];
            string wordTwo = input[1];


            int lenght = Math.Max(input[1].Length, input[0].Length);

            string result = Multiplier(wordOne, wordTwo).ToString().PadRight(lenght, '0');


            Console.WriteLine(result);
        }

        private static int Multiplier(string one, string two)
        {
            char[] firstCh = one.ToCharArray();
            char[] secondCh = two.ToCharArray();

            int sum = 0;


            if (firstCh.Length == secondCh.Length)
            {
                for (int i = 0; i < firstCh.Length; i++)
                {
                    sum += firstCh[i] * secondCh[i];
                }
            }

            if (one.Length.Equals(two.Length) == false)
            {
                if (one.Length < two.Length)
                {
                    sum = firstCh[0];
                }
                else
                {
                    sum = secondCh[0];
                }
            }

            return sum;
        }
    }
}