using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_instances
{
    internal class Course
    {
        private string courseName;
        private string courseDuration;
        private double courseFee;

        // class variable
        public static string instituteName;

        public Course(string courseName, string courseDuration, double courseFee)
        {
            this.courseName = courseName;
            this.courseDuration = courseDuration;
            this.courseFee = courseFee;
        }

        // Instance Method
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Duration: " + courseDuration);
            Console.WriteLine("Course Fee: INR " + courseFee);
        }

        // Class Method

        public static string UpdateInstituteName(string institute)
        {
            instituteName = institute;
            return instituteName;
        }
    }

    class OnlineCourseManagement
    {
        public static void Main(string[] args)
        {
            Course.UpdateInstituteName("BridgeLabz");
            Console.WriteLine();

            Course c1 = new Course("C#", "6 Months", 24000.0);
            Course c2 = new Course("Blender", "4 Months", 22000.0);
            Course c3 = new Course("Automation", "5 Months", 20000.0);

            Console.WriteLine("Institute Name: " + Course.instituteName);

            Console.WriteLine("Course 1 Details: ");
            c1.DisplayCourseDetails();
            Console.WriteLine();
            
            Console.WriteLine("Course 2 Details: ");
            c2.DisplayCourseDetails();
            Console.WriteLine();
            
            Console.WriteLine("Course 3 Details: ");
            c3.DisplayCourseDetails();
            Console.WriteLine();

            
        }
    }
}
