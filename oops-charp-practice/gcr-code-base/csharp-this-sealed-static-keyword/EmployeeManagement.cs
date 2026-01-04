using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_this_sealed_static_keyword
{
    internal class Employee
    {
        // Static Variables
        public static string CompanyName;
        private static int totalEmployees = 0;

        // Instance Variables
        public string Name;
        public readonly int Id;
        public string Designation;

        public Employee(string Name, int Id, string Designation)
        {
            // using this keyword
            this.Name = Name;
            this.Id = Id;
            this.Designation = Designation;

            totalEmployees++;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Company Name : " + CompanyName);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee ID  : " + Id);
            Console.WriteLine("Designation  : " + Designation);
        }

        // Static Method
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees : " + totalEmployees);
        }
    }

    class EmployeeManagement
    {
        public static void Main(string[] args)
        {
            Employee.CompanyName = "BridgeLabz";

            Employee emp1 = new Employee("James", 101, "Software Developer");
            Employee emp2 = new Employee("Adam", 102, "Tester");

            Console.WriteLine("Employee 1 Details:");
            if (emp1 is Employee)
            {
                emp1.DisplayEmployeeDetails();
            }
            Console.WriteLine();

            Console.WriteLine("Employee 2 Details:");
            if (emp2 is Employee)
            {
                emp2.DisplayEmployeeDetails();
            }
            Console.WriteLine();

            Employee.DisplayTotalEmployees();
        }
    }
}
