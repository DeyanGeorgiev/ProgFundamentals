using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());


            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;


            if (nightsCount >= 0 && nightsCount <= 200)
            {
                double duble;
                double studio;
                double suite;


                switch (month)
                {
                    case "May":

                        studio = 50.00;
                        duble = 65.00;
                        suite = 75.00;

                        priceSuite = nightsCount * suite;
                        priceDouble = nightsCount * duble;

                        if (nightsCount > 7)
                        {
                            priceStudio = (nightsCount * studio) - (nightsCount * studio * 5 / 100.0);
                        }
                        else
                        {
                            priceStudio = nightsCount * studio;
                        }

                        break;

                    case "June":

                        studio = 60.00;
                        duble = 72.00;
                        suite = 82.00;

                        priceSuite = nightsCount * suite;
                        priceStudio = nightsCount * studio;

                        if (nightsCount > 14)
                        {
                            priceDouble = (nightsCount * duble) - (nightsCount * duble * 10 / 100.0);
                        }
                        else
                        {
                            priceDouble = nightsCount * duble;
                        }

                        break;


                    case "July":
                    case "August":
                    case "December":

                        studio = 68.00;
                        duble = 77.00;
                        suite = 89.00;

                        priceDouble = nightsCount * duble;
                        priceStudio = nightsCount * studio;

                        if (nightsCount > 14)
                        {
                            priceSuite = (nightsCount * suite) - (nightsCount * suite * 15 / 100.0);
                        }
                        else
                        {
                            priceSuite = nightsCount * suite;
                        }

                        break;


                    case "September":

                        studio = 60.00;
                        duble = 72.00;
                        suite = 82.00;

                        priceSuite = nightsCount * suite;

                        if (nightsCount > 14)
                        {
                            priceDouble = (nightsCount * duble) - (nightsCount * duble * 10 / 100.0);
                            priceStudio = (nightsCount * studio) - studio;
                        }

                        else
                        {
                            priceDouble = nightsCount * duble;

                            if (nightsCount > 7)
                            {
                                priceStudio = (nightsCount * studio) - studio;
                            }
                            else
                            {
                                priceStudio = nightsCount * studio;
                            }
                        }

                        break;

                    case "October":

                        studio = 50.00;
                        duble = 65.00;
                        suite = 75.00;


                        priceSuite = nightsCount * suite;
                        priceDouble = nightsCount * duble;

                      //  double dicount;

                        if (nightsCount > 7)
                        {
                           
                            priceStudio = ((nightsCount * studio)-studio) - (((nightsCount * studio)-studio) * 5 / 100.0);
                        }
                        else
                        {
                            priceStudio = nightsCount * studio;
                        }

                        break;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
            Console.WriteLine("Double: {0:f2} lv.", priceDouble);
            Console.WriteLine("Suite: {0:f2} lv.", priceSuite);
        }
    }
}