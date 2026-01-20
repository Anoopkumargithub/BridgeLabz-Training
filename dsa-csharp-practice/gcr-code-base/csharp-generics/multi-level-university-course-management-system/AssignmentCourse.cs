using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.multi_level_university_course_management_system
{
    internal class AssignmentCourse : CourseType
    {
        private int assignmentCount;

        public AssignmentCourse(int count)
            : base("Assignments")
        {
            assignmentCount = count;
        }

        public override string GetEvaluationDetails()
        {
            return $"{evaluationMethod}, Assignments: {assignmentCount}";
        }
    }
}
