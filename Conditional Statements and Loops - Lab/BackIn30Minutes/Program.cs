using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min= int.Parse(Console.ReadLine());


            if ( hour>=0 && hour <=23 && min >= 0 && min <=59){


                int checkHour= hour+1;
                int checkMin= min+30;

                int resultMin= 0;
                int resultHour= 0;


                if (checkMin> 59){

                    resultMin= checkMin-60;
                    resultHour= hour+ 1;


                } else{

                    resultMin= min+ 30;
                    resultHour= hour;
                }



                if ( checkHour> 23 || hour==0){

                    if (checkMin> 59){

                        resultMin= checkMin-60;
                        resultHour= 0;


                    } else{

                        resultMin= min+ 30;
                        resultHour= 0;
                    }


                }

                Console.WriteLine($"{resultHour}:{resultMin:d2}");
            }
        }
    }
}