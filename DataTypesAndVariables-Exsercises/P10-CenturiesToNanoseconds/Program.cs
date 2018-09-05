using System;
using System.Numerics;

namespace P10_CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());

            byte centures = num;
            int years = centures * 100;
            int days = (int) (years * 365.2422);
            int hours = days * 24;
            int min = hours * 60;
            long sec = min * 60L;
            long milisec = sec * 1000L;
            ulong micro = (ulong) (milisec * 1000);
            BigInteger nano = (BigInteger) micro * 1000;
            


            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {min} minutes = " +
                              $"{sec} seconds = {milisec} milliseconds = {micro} microseconds = {nano} nanoseconds");
        }

        
    }
}