using System;

namespace One
{
    class Program
    {
        static void Main()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            
            int firstEfficency= 0 ;
            int secEfficency = 0;
            int thirdEfficency = 0;
            
            if (input1 >= 1 && input1 <= 100
                || input2 >= 1 && input2 <= 100
                || input3 >= 1 && input3 <= 100)
            {

                 firstEfficency = input1;
                 secEfficency = input2;
                 thirdEfficency = input3;
            }

             int secInput = int.Parse(Console.ReadLine());
            
            
            int studentsCount = 0;

            if (secInput >= 0 && secInput <= 10000)
            {
                studentsCount = secInput;
            }

            int sumAllEmplAnswerStd = firstEfficency + secEfficency + thirdEfficency;

            int leftStudent = studentsCount- sumAllEmplAnswerStd;;

            int timeNeed = 1;

            while (leftStudent > 0)
            {
                
                leftStudent -= sumAllEmplAnswerStd;
                
                timeNeed += 1;

                if (timeNeed % 4== 0)
                {
                    timeNeed += 1;
                }
                
            }

            Console.WriteLine($"Time needed: {timeNeed}h.");
            
        }
    }
}