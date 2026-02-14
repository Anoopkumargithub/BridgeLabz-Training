using System;
using HealthCare.Menu;
using HealthCare.Service;
using HealthCare.Repository;
using HealthCare.Interfaces;

class Program
{
    static void Main()
    {
        IVisitRepository visitRepo = new VisitRepository();
        IAppointmentRepository appointmentRepo = new AppointmentRepository();
        IPatientRepository patientRepo = new PatientRepository();
        IDoctorRepository doctorRepo = new DoctorRepository();
        ISpecialityRepository specialityRepo = new SpecialityRepository();

        VisitService visitService = new VisitService(visitRepo, appointmentRepo);
        AppointmentService appointmentService =
            new AppointmentService(appointmentRepo, patientRepo, doctorRepo);
        PatientService patientService = new PatientService();

        ReceptionistMenu receptionistMenu =
            new ReceptionistMenu(appointmentService, patientService);

        PatientMenu patientMenu = new PatientMenu();
        AdminMenu adminMenu = new AdminMenu(visitService);
        

        // =========================
        // Main Menu
        // =========================
        while (true)
        {
            Console.WriteLine("\n===== HEALTHCARE MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Admin Panel");
            Console.WriteLine("2. Receptionist Panel");
            Console.WriteLine("3. Patient Module");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    adminMenu.Show();
                    break;

                case "2":
                    receptionistMenu.Show();
                    break;

                case "3":
                    patientMenu.Show();
                    break;

                case "0":
                    Console.WriteLine("Exiting system...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
