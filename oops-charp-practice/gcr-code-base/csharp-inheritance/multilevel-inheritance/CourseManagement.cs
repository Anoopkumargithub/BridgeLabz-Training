using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_inheritance.multilevel_inheritance
{
    // Base Class
    internal class Course
    {
        protected string CourseName;
        protected string Duration;

        public Course(string CourseName, string Duration)
        {
            this.CourseName = CourseName;
            this.Duration = Duration;
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Duration    : " + Duration);
        }
    }

    // Subclass (Level 1)
    internal class OnlineCourse : Course
    {
        protected string Platform;
        protected bool IsRecorded;

        public OnlineCourse(string CourseName, string Duration, string Platform, bool IsRecorded)
            : base(CourseName, Duration)
        {
            this.Platform = Platform;
            this.IsRecorded = IsRecorded;
        }

        public void DisplayOnlineCourseInfo()
        {
            DisplayCourseInfo();
            Console.WriteLine("Platform    : " + Platform);
            Console.WriteLine("Recorded    : " + IsRecorded);
        }
    }

    // Subclass (Level 2)
    internal class PaidOnlineCourse : OnlineCourse
    {
        private double Fee;
        private double Discount;

        public PaidOnlineCourse(string CourseName, string Duration, string Platform, bool IsRecorded, double Fee, double Discount)
            : base(CourseName, Duration, Platform, IsRecorded)
        {
            this.Fee = Fee;
            this.Discount = Discount;
        }

        public void DisplayPaidCourseInfo()
        {
            DisplayOnlineCourseInfo();
            Console.WriteLine("Course Fee  : INR " + Fee);
            Console.WriteLine("Discount    : " + Discount + "%");
        }
    }

    class CourseManagement
    {
        public static void Main(string[] args)
        {
            PaidOnlineCourse course1 = new PaidOnlineCourse(
                "C# Full Stack",
                "6 Months",
                "Udemy",
                true,
                2000,
                50
            );

            Console.WriteLine("Course Details:");
            course1.DisplayPaidCourseInfo();
        }
    }
}
