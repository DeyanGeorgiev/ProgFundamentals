using System;

namespace P02_AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            for (int i = 0; i < input; i++)
            {
                string[] phrase =
                    {
                        "Excellent product.",
                        "Such a great product.",
                        "I always use that product.",
                        "Best product of its category.",
                        "Exceptional product.",
                        "I can’t live without this product."
                    }
                    ;


                string[] events =
                {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
                };

                string[] author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

                string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

                Random randomPhrase = new Random();

                int pos1 = randomPhrase.Next(0, phrase.Length);


                string temp1 = phrase[pos1];


                Random randomEvents = new Random();


                int pos3 = randomEvents.Next(0, events.Length);


                string temp2 = events[pos3];


                Random randomAuthor = new Random();


                int pos5 = randomAuthor.Next(0, author.Length);


                string temp3 = author[pos5];


                Random randomCities = new Random();


                int pos7 = randomCities.Next(0, cities.Length);


                string temp4 = cities[pos7];


                Console.WriteLine($"{temp1} {temp2} {temp3} – {temp4}");
            }
        }
    }
}