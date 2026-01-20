using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.multi_level_university_course_management_system
{
    internal class Menu
    {
        private IUniversityService service;

        public Menu()
        {
            service = new UniversityService(); // upcasting
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- University Course Management ---");
                Console.WriteLine("1. Add Exam Based Course");
                Console.WriteLine("2. Add Assignment Based Course");
                Console.WriteLine("3. Display All Courses");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddExamCourse();
                        break;
                    case 2:
                        service.AddAssignmentCourse();
                        break;
                    case 3:
                        service.DisplayAllCourses();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
