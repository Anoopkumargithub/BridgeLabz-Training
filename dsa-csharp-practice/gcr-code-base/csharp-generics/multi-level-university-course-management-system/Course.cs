using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.multi_level_university_course_management_system
{
    internal class Course<T> where T : CourseType
    {
        public string CourseName { get; private set; }
        public string Department { get; private set; }
        public T EvaluationType { get; private set; }

        public Course(string name, string department, T evaluationType)
        {
            CourseName = name;
            Department = department;
            EvaluationType = evaluationType;
        }

        public override string ToString()
        {
            return $"Course: {CourseName}, Dept: {Department}, Evaluation: {EvaluationType.GetEvaluationDetails()}";
        }
    }
}
