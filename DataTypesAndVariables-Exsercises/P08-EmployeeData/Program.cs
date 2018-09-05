using System;

namespace P08_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string secName = "Jonson";
            byte age = 27;
            string gender = "f";
            long personId = 8306112507;
            int emplNum = 27563571;

            Console.WriteLine("First name: "+firstName+Environment.NewLine+"Last name: "+secName
                +Environment.NewLine+"Age: "+age+
               Environment.NewLine+"Gender: "+gender+
                Environment.NewLine+"Personal ID: "+personId+
                Environment.NewLine+"Unique Employee number: "+ emplNum);

        }
    }
}