using System;
using System.Globalization;

namespace P03_EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if (number != null)
            {
                string result = number.Substring(number.Length - 1);

                Console.WriteLine(GetName(result));
            }
        }

        public static string GetName(string result)
        {
            string text = "";

            switch (result)
            {
                case "1":
                    text = "one";
                    break;
                case "2":
                    text = "two";
                    break;
                case "3":
                    text = "three";
                    break;
                case "4":
                    text = "four";
                    break;
                case "5":
                    text = "five";
                    break;
                case "6":
                    text = "six";
                    break;
                case "7":
                    text = "seven";
                    break;
                case "8":
                    text = "eight";
                    break;
                case "9":
                    text = "nine";
                    break;
                case "0":
                    text = "zero";
                    break;
            }


            return text;
        }
    }
}