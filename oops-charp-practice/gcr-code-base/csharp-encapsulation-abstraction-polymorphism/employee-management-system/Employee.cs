using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism.employee_management_system
{
    internal class Employee
    {
        private int employeeId;
        private string name;
        protected double baseSalary;
        private string department;

        public int EmployeeId
        {
            get { return employeeId; }
        }

        public string Name
        {
            get { return name; }
        }

        protected Employee(int employeeId, string name, double baseSalary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        protected void SetDepartment(string dept)
        {
            department = dept;
        }

        protected string GetDepartment()
        {
            return department;
        }

        public abstract double CalculateSalary();
 

        public override string? ToString()
        {
            return "Employee ID: " + employeeId +
                "Name: " + name +
                "Department: " + department +
                "Salary: INR " + CalculateSalary();
        }

    }
}
