using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism.employee_management_system
{
    internal class EmployeeUtility
    {
        private Employee[] employees;
        private int count;

        public EmployeeUtility(int size)
        {
            employees = new Employee[size];
            count = 0;
        }

        public void AddEmployee(Employee employee)
        {
            if (count < employees.Length)
            {
                employees[count] = employee;
                count++;
                Console.WriteLine("Employee added successfully");
            }
            else
            {
                Console.WriteLine("Employee storage full");
            }
        }

        public void DisplayAllEmployees()
        {
            for (int i = 0; i < count; i++)
            {
                employees[i].DisplayDetails();
                Console.WriteLine("---------------------");
            }
        }
    }
}
