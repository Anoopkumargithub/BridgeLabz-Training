using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_generics.multi_level_university_course_management_system
{
    internal abstract class CourseType
    {
        protected string evaluationMethod;

        protected CourseType(string method)
        {
            evaluationMethod = method;
        }

        public abstract string GetEvaluationDetails();
    }
}
