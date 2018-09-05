using System;
using System.Linq;

namespace P06_Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArr = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < myArr.Length/ 2; i++)
            {
                string temp = myArr[i];
                myArr[i] = myArr[myArr.Length - 1 - i];
                myArr[myArr.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", myArr));
        }
    }
}