using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism.employee_management_system
{
    internal class FullTimeEmployee : Employee, IDepartment
    {
        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name, salary) { }

        public override double CalculateSalary()
        {
            return baseSalary;
        }

        public void AssignDepartment(string department)
        {
            SetDepartment(department);
        }

        public string GetDepartmentDetails()
        {
            return GetDepartment();
        }
    }
}
