using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_access_modifiers
{
    internal class Student
    {
        // Public Variable
        public int rollNumber;

        // Protected Variable
        protected string name;

        // Private Variable
        private double cgpa;

        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        // Public Method to Get CGPA
        public double GetCGPA()
        {
            return cgpa;
        }

        // Public Method to Set CGPA
        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll Number : " + rollNumber);
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("CGPA        : " + cgpa);
        }
    }

    // Subclass
    internal class PostgraduateStudent : Student
    {
        private string specialization;

        public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
            : base(rollNumber, name, cgpa)
        {
            this.specialization = specialization;
        }

        public void DisplayPGStudentDetails()
        {
            Console.WriteLine("Roll Number    : " + rollNumber);
            Console.WriteLine("Name           : " + name); // protected member accessed
            Console.WriteLine("Specialization : " + specialization);
            Console.WriteLine("CGPA           : " + GetCGPA()); // private accessed via public method
        }
    }

    class UniversityManagement
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student(101, "Anoop", 8.2);
            Console.WriteLine("Student Details:");
            s1.DisplayStudentDetails();
            Console.WriteLine();

            s1.SetCGPA(8.7);
            Console.WriteLine("Updated CGPA: " + s1.GetCGPA());
            Console.WriteLine();

            PostgraduateStudent pg1 = new PostgraduateStudent(201, "Rahul", 8.9, "Computer Science");
            Console.WriteLine("Postgraduate Student Details:");
            pg1.DisplayPGStudentDetails();
        }
    }
}
