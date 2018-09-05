using System;

namespace P12_MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            for (int i = 1; i <= input; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                bool sumOfDigits = SumOfDigits(i);
                bool containsEvenDigit = ContainsEvenDigit(i);

                bool master = isPalindrome && sumOfDigits && containsEvenDigit;

                if (master)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int num)
        {


//            string revised = "";
//            int originalNumber = num;
//            while (num >0)
//            {
//                int digit = num % 10;
//                revised += digit;
//
//                num /= 10;
//
//            }
            
            int rem = 0;
            int sum = 0;
            int temp = 0;


            temp = num;
            while (num > 0)
            {
                rem = num % 10; //for getting remainder by dividing with 10    
                num = num / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + rem;
                /*multiplying the sum with 10 and adding  
                remainder*/
            }


           //  int reverNum = int.Parse(revised);

            bool palindrome = sum == temp;
            return palindrome;
        }

        static bool SumOfDigits(int num)
        {
     //       int holder = 0;
            int sum = 0;
            
            while (num >0)
            {
                int digit = num % 10;
                sum += digit;

                num /= 10;

            }
            


            bool result = sum % 7 == 0;
            return result;
        }

        static bool ContainsEvenDigit(int num)
        {
         
            bool result = false;
           
            
            while (num >0)
            {
                int digit = num % 10;

                if (digit % 2 == 0)
                {
                    result = true;
                    break;
                }

                num /= 10;

            }


            
            return result;
        }
    }
}