using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism.employee_management_system
{
    internal class EmployeeMenu
    {
        private EmployeeUtility utility;

        public EmployeeMenu(EmployeeUtility utility)
        {
            this.utility = utility;
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Employee Management Menu ---");
                Console.WriteLine("1. Add Full Time Employee");
                Console.WriteLine("2. Add Part Time Employee");
                Console.WriteLine("3. Display All Employees");
                Console.WriteLine("4. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddFullTimeEmployee();
                        break;

                    case 2:
                        AddPartTimeEmployee();
                        break;

                    case 3:
                        utility.DisplayAllEmployees();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }

        private void AddFullTimeEmployee()
        {
            Employee emp = new FullTimeEmployee(101, "Anoop", 50000);
            ((IDepartment)emp).AssignDepartment("IT");
            utility.AddEmployee(emp);
        }

        private void AddPartTimeEmployee()
        {
            Employee emp = new PartTimeEmployee(102, "Rahul", 500, 40);
            ((IDepartment)emp).AssignDepartment("Support");
            utility.AddEmployee(emp);
        }
    }
}
