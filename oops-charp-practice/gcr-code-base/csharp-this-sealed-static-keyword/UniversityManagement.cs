using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_this_sealed_static_keyword
{
    internal class Student
    {
        // Static Variables
        public static string UniversityName;
        private static int totalStudents = 0;

        // Instance Variables
        public string Name;
        public readonly int RollNumber;
        private string Grade;

        public Student(string Name, int RollNumber, string Grade)
        {
            // using this keyword
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;

            totalStudents++;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("University Name : " + UniversityName);
            Console.WriteLine("Student Name    : " + Name);
            Console.WriteLine("Roll Number     : " + RollNumber);
            Console.WriteLine("Grade           : " + Grade);
        }

        // Static Method
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students Enrolled : " + totalStudents);
        }
    }

    class UniversityManagement
    {
        public static void Main(string[] args)
        {
            Student.UniversityName = "Delhi University";

            Student s1 = new Student("Aatma Ram", 101, "A");
            Student s2 = new Student("Popat Lal", 102, "B");

            Console.WriteLine("Student 1 Details:");
            if (s1 is Student)
            {
                s1.DisplayStudentDetails();
            }
            Console.WriteLine();

            Console.WriteLine("Student 2 Details:");
            if (s2 is Student)
            {
                s2.DisplayStudentDetails();
            }
            Console.WriteLine();

            Student.DisplayTotalStudents();
        }
    }
}
