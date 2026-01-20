using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.multi_level_university_course_management_system
{
    internal class UniversityService : IUniversityService
    {
        // Variance-safe storage using base reference
        private List<object> courses = new List<object>();

        public void AddExamCourse()
        {
            Console.Write("Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Department: ");
            string dept = Console.ReadLine();

            Console.Write("Exam Duration (hours): ");
            int duration = int.Parse(Console.ReadLine());

            var course = new Course<ExamCourse>(
                name, dept, new ExamCourse(duration));

            courses.Add(course);
        }

        public void AddAssignmentCourse()
        {
            Console.Write("Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Department: ");
            string dept = Console.ReadLine();

            Console.Write("Number of Assignments: ");
            int count = int.Parse(Console.ReadLine());

            var course = new Course<AssignmentCourse>(
                name, dept, new AssignmentCourse(count));

            courses.Add(course);
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("\n--- University Courses ---");
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
