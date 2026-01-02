using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_class_object
{
    internal class EmployeeClass
    {
        private string name;
        private int id;
        private double salary; 

        public EmployeeClass(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee Id: {id}");
            Console.WriteLine($"Employee Salary: INR {salary}");
        }
    }

    public class Program
    {
        public static void Main( string[] args )
        {
            // define Employee data
            string name = "Adma";
            int id = 0011;
            double salary = 20000.0;

            // create Employee Class object

            EmployeeClass Employee = new EmployeeClass( name, id, salary );

            // Display Employee Data

            Employee.DisplayDetails();
        }
    }
}
