using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism.employee_management_system
{
    internal interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }
}
