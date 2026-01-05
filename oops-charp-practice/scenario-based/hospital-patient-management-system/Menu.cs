using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.hospital_patient_management_system
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n===== Hospital Management Menu =====");
            Console.WriteLine("1. View Patients");
            Console.WriteLine("2. View Doctor");
            Console.WriteLine("3. View Doctor's Assigned Patients");
            Console.WriteLine("4. Generate Bill");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
