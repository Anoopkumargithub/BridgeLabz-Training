using System;
using HealthCare.Menu;
using HealthCare.Service;
using HealthCare.Repository;
using HealthCare.Interfaces;

class Program
{
    static void Main()
    {
        // Repositories
        IPrescriptionRepository prescriptionRepo = new PrescriptionRepository();
        IVisitRepository visitRepo = new VisitRepository();
        IAppointmentRepository appointmentRepo = new AppointmentRepository();
        IPatientRepository patientRepo = new PatientRepository();
        IDoctorRepository doctorRepo = new DoctorRepository();
        ISpecialityRepository specialityRepo = new SpecialityRepository();
        IBillingRepository billingRepo = new BillingRepository();

        // Services
        PrescriptionService prescriptionService = new PrescriptionService(prescriptionRepo, visitRepo);
        VisitService visitService = new VisitService(visitRepo, appointmentRepo);
        DoctorService doctorService = new DoctorService();
        SpecialityService specialityService = new SpecialityService();
        AppointmentService appointmentService = new AppointmentService(appointmentRepo, patientRepo, doctorRepo);
        PatientService patientService = new PatientService();
        BillingService billingService = new BillingService(billingRepo);

        // Menus
        AdminMenu adminMenu = new AdminMenu(doctorService);
        ReceptionistMenu receptionistMenu = new ReceptionistMenu(appointmentService, patientService);
        PatientMenu patientMenu = new PatientMenu(patientService, billingService);
        DoctorPanelMenu doctorPanelMenu = new DoctorPanelMenu(visitService, prescriptionService);

        while (true)
        {
            Console.WriteLine("\n===== HEALTHCARE MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Admin Panel");
            Console.WriteLine("2. Receptionist Panel");
            Console.WriteLine("3. Patient Panel");
            Console.WriteLine("4. Doctor Panel");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": adminMenu.Show(); break;
                case "2": receptionistMenu.Show(); break;
                case "3": patientMenu.Show(); break;
                case "4":
                    Console.Write("Enter your Doctor ID: ");
                    int doctorId = int.Parse(Console.ReadLine());
                    doctorPanelMenu.Show(doctorId);
                    break;
                case "0": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}
