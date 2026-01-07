using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_encapsulation_abstraction_polymorphism.employee_management_system
{
    class EmployeeMain
    {
        static void Main(string[] args)
        {
            EmployeeUtility utility = new EmployeeUtility(10);
            EmployeeMenu menu = new EmployeeMenu(utility);
            menu.ShowMenu();
        }
    }
}
