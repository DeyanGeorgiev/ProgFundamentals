using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P08_MentorGroup
{
    class Student
    {
        public Student(List<string> comments, List<DateTime> attendance, string name)
        {
            Comments = comments;
            Attendance = attendance;
            Name = name;
        }

        public Student()
        {
        }


        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            
            Student student = new Student();
            List<DateTime> presenceDates = new List<DateTime>();
            List<string> notes = new List<string>();


            while (true)
            {
                string coming = Console.ReadLine();

                if (coming.Equals("end of dates"))
                {
                    break;
                }

                string[] input = coming
                    .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                input = input.Skip(1).ToArray();


                

                for (int i = 0; i < input.Length; i++)
                {
                    presenceDates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                student.Name = name;
                student.Attendance = presenceDates;

                if (students.ContainsKey(student.Name)== false)
                {
                    students.Add(student.Name, student);
                    student.Attendance = presenceDates;
                }
                else
                {
                    students[name].Attendance.AddRange(presenceDates);
                }

                Console.WriteLine();
            }

            while (true)
            {
                string coming2 = Console.ReadLine();

                if (coming2.Equals("end of comments"))
                {
                    break;
                }

                string[] input2 = coming2
                    .Split("-");

                string name = input2[0];
                string comment = input2[1];
                List<string> comments= new List<string>();
                comments.Add(comment);
                
                student.Name = name;
                student.Comments = comments;

                if (students.ContainsKey(name))
                {
                    if (students[name].Comments != null)
                    {
                        students[name].Comments.AddRange(comments);
                    }
                    else
                    {
                        students[name].Comments = comments;
                    }            
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine("{0}", item.Key);
                Console.WriteLine("Comments:");

                if (item.Value.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine("- {0}", comment);
                    }
                }

                    Console.WriteLine("Dates attended:");
                    
                
                
            }

           
        }
    }
}