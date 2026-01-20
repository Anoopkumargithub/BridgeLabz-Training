using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.multi_level_university_course_management_system
{
    internal class ExamCourse : CourseType
    {
        private int examDuration;

        public ExamCourse(int duration)
            : base("Written Exam")
        {
            examDuration = duration;
        }

        public override string GetEvaluationDetails()
        {
            return $"{evaluationMethod}, Duration: {examDuration} hours";
        }
    }
}
