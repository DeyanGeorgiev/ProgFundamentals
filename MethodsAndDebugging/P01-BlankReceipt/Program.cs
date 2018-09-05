using System;

namespace P01_BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptMiddle();
            PrintReceiptBottom();
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT" + Environment.NewLine + "------------------------------");
        }

        static void PrintReceiptMiddle()
        {
            Console.WriteLine("Charged to____________________" + Environment.NewLine +
                              "Received by___________________");
        }

        static void PrintReceiptBottom()
        {
            Console.WriteLine("© SoftUni");
        }
    }
}