using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.hospital_patient_management_system
{
    internal class HospitalManagement
    {
        public static void Main(string[] args)
        {
            InPatient p1 = new InPatient(101, "John", 5);
            InPatient p2 = new InPatient(103, "Adam", 8);
            InPatient p3 = new InPatient(104, "Carter", 8);

            Patients[] patientList1 = { p1, p2 };
            Patients[] patientList2 = { p3 };

            Doctors d1 = new Doctors(1, "Dr. Bhide", patientList1, 1000);
            Doctors d2 = new Doctors(2, "Dr. Haathi", patientList2, 5000);

            Doctors[] doctors = { d1, d2 };

            bool running = true;

            while (running)
            {
                Menu.ShowMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                Utility.PrintLine();

                switch (choice)
                {
                    // 1️⃣ View all patients
                    case 1:
                        Console.WriteLine("All Patients:\n");
                        p1.DisplayAccountInfo();
                        p2.DisplayAccountInfo();
                        p3.DisplayAccountInfo();
                        break;

                    // 2️⃣ View all doctors
                    case 2:
                        Console.WriteLine("Doctors List:\n");
                        foreach (Doctors doc in doctors)
                        {
                            doc.DisplayAccountInfo();
                            Utility.PrintLine();
                        }
                        break;

                    // 3️⃣ View patients under selected doctor
                    case 3:
                        Console.WriteLine("Select Doctor:");
                        for (int i = 0; i < doctors.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {doctors[i].getDoctorName}");
                        }

                        int docChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (docChoice >= 0 && docChoice < doctors.Length)
                        {
                            doctors[docChoice].PatientData();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Doctor Selection");
                        }
                        break;

                    // 4️⃣ Generate Bill
                    case 4:
                        Console.WriteLine("Select Doctor:");
                        for (int i = 0; i < doctors.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {doctors[i].getDoctorName}");
                        }

                        int dIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (dIndex < 0 || dIndex >= doctors.Length)
                        {
                            Console.WriteLine("Invalid Doctor Selection");
                            break;
                        }

                        Doctors selectedDoctor = doctors[dIndex];

                        Console.WriteLine("Select Patient:");
                        Patients[] docPatients = selectedDoctor.GetPatients();

                        for (int i = 0; i < docPatients.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {docPatients[i].Name}");
                        }

                        int pIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (pIndex < 0 || pIndex >= docPatients.Length)
                        {
                            Console.WriteLine("Invalid Patient Selection");
                            break;
                        }

                        InPatient selectedPatient = docPatients[pIndex] as InPatient;

                        if (selectedPatient == null)
                        {
                            Console.WriteLine("Bill can be generated only for InPatients");
                            break;
                        }

                        Bills bill = new Bills(selectedPatient, selectedDoctor);
                        Console.WriteLine("Total Bill Amount: " + bill.CalculateBill());
                        break;

                    // 5️⃣ Exit
                    case 5:
                        running = false;
                        Console.WriteLine("Exiting System...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
