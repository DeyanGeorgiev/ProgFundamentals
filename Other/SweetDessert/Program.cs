using System;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double chash = double.Parse(Console.ReadLine());
            int numGuests= int.Parse(Console.ReadLine());
            double priceBanana= double.Parse(Console.ReadLine());
            double priceEgg = double.Parse(Console.ReadLine());
            double priceBerryes= double.Parse(Console.ReadLine());

            double priceForMinPortions = priceBanana * 2.0 + 4.0 * priceEgg + 0.2 * priceBerryes;
            
            // checkSet 

            double needPortions = Math.Ceiling(numGuests / 6.0);

            double needMoney = priceForMinPortions * needPortions;
            
           

            if (needMoney <= chash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {needMoney:f2}lv.”");
            }
            else
            {
                double need = Math.Abs(chash - needMoney);
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {need:f2}lv more.");
            }


        }
    }
}