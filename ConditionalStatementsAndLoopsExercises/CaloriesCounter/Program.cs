using System;
 
 namespace CaloriesCounter
 {
     class Program
     {
         public static void Main()
         {
             int num = int.Parse(Console.ReadLine());
             
 
 
             int count = 0;
 
             for (int i = 1; i <= num; i++)
                 
                
             {
                 
                 string ingradient = Console.ReadLine().ToLower();
                 if (ingradient.Equals("cheese"))
                 {
                     count += 500;
 
           
                 }
                 else if (ingradient.Equals("tomato sauce"))
                 {
                     count += 150;
 
                     
                 }
                 else if (ingradient.Equals("salami"))
                 {
                     count += 600;
 
                     

                 }
                 else if (ingradient.Equals("pepper"))
                 {
                     count += 50;
 
                     
                 }
                 
             }
 
             Console.WriteLine($"Total calories: {count}");
         }
     }
 }