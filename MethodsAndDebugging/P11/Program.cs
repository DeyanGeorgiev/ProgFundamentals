using System;

namespace P11
{
    internal static class P11
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double givenPrices = double.Parse(Console.ReadLine());


            for (int i = 0; i < n - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());

                double div = Proc(givenPrices, price);
                bool isSignificantDifference = IsThereADiff(div, threshold);


                string message = Get(price, givenPrices, div, isSignificantDifference);
                Console.WriteLine(message);


                givenPrices = price;
            }
        }

        private static string Get(double price, double givenPrice, double diff, bool etherTrueOrFalse)


        {
            string to = "";
            if (diff == 0)
            {
                to = string.Format("NO CHANGE: {0}", price);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", givenPrice, price, diff*100);
            }
            else if (etherTrueOrFalse && (diff > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", givenPrice, price, diff*100);
            }
            else if (etherTrueOrFalse && (diff < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", givenPrice, price, diff*100);

            return to;
        }

        private static bool IsThereADiff(double limit, double isDiff)
        {
            if (Math.Abs(limit) >= isDiff)
            {
                return true;
            }

            return false;
        }

        private static double Proc(double l, double c)
        {
            double r = (c - l)  / l;
            return r;
        }
    }
}