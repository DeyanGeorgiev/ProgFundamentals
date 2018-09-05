using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int lostGamesCount  = int.Parse(Console.ReadLine());
            
            float headsetPrice= float.Parse(Console.ReadLine());
            
            float mousePrice= float.Parse(Console.ReadLine());
            
            float keyboardPrice= float.Parse(Console.ReadLine());
            
            float displayPrice= float.Parse(Console.ReadLine());


            int trashHeadset = 0;
            int trashMouse = 0;
            int trashKeyboard = 0;

            int numCheck = 0;
            int trashDisplay = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                bool hasTrashHeadset = false;
                if (i % 2 == 0)
                {
                    trashHeadset = trashHeadset + 1;
                    hasTrashHeadset= true;
                }

                bool hasTrashMouse = false;
                if (i % 3 == 0)
                {
                    trashMouse = trashMouse+1;
                    hasTrashMouse = true;
                }

                if (hasTrashHeadset && hasTrashMouse)
                {
                    trashKeyboard = trashKeyboard+ 1;

                    numCheck = numCheck + 1;
                }

                if (numCheck  == 2)
                {
                    trashDisplay = trashDisplay+1;
                    numCheck = 0;


                }

                
            }
            
            

            float result = headsetPrice * trashHeadset + trashDisplay * displayPrice + trashKeyboard * keyboardPrice +
                           trashMouse * mousePrice;
            
                
                
            Console.WriteLine($"Rage expenses: {result:f2} lv.");
            
            
        }
    }
}