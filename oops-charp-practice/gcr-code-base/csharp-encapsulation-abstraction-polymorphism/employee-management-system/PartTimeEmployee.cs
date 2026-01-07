using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism.employee_management_system
{
    internal class PartTimeEmployee : Employee, IDepartment
    {
        private int workHours;

        public PartTimeEmployee(int id, string name, double hourlyRate, int workHours)
            : base(id, name, hourlyRate)
        {
            this.workHours = workHours;
        }

        public override double CalculateSalary()
        {
            return baseSalary * workHours;
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
