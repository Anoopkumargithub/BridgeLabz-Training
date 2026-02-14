using System;
using HealthCare.Menu;
using HealthCare.Service;
using HealthCare.Repository;
using HealthCare.Interfaces;
using HealthCare.Models;

class Program
{
    static void Main()
    {
        // =========================
        // Repositories
        // =========================
        IUserRepository userRepo = new UserRepository();
        IPrescriptionRepository prescriptionRepo = new PrescriptionRepository();
        IVisitRepository visitRepo = new VisitRepository();
        IAppointmentRepository appointmentRepo = new AppointmentRepository();
        IPatientRepository patientRepo = new PatientRepository();
        IDoctorRepository doctorRepo = new DoctorRepository();
        ISpecialityRepository specialityRepo = new SpecialityRepository();
        IBillingRepository billingRepo = new BillingRepository();

        // =========================
        // Services
        // =========================
        UserService userService = new UserService(userRepo);
        PrescriptionService prescriptionService = new PrescriptionService(prescriptionRepo, visitRepo);
        VisitService visitService = new VisitService(visitRepo, appointmentRepo);
        DoctorService doctorService = new DoctorService();
        SpecialityService specialityService = new SpecialityService();
        AppointmentService appointmentService = new AppointmentService(appointmentRepo, patientRepo, doctorRepo);
        PatientService patientService = new PatientService();
        BillingService billingService = new BillingService(billingRepo);

        // =========================
        // Menus
        // =========================
        LoginMenu loginMenu = new LoginMenu(userService);
        AdminMenu adminMenu = new AdminMenu(doctorService, userService);
        ReceptionistMenu receptionistMenu = new ReceptionistMenu(appointmentService, patientService);
        PatientMenu patientMenu = new PatientMenu(patientService, billingService);
        DoctorPanelMenu doctorPanelMenu = new DoctorPanelMenu(visitService, prescriptionService);

        // =========================
        // Application Loop
        // =========================
        bool exitApplication = false;
        while (!exitApplication)
        {
            Console.WriteLine("\n===== HEALTHCARE MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Login");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            string mainChoice = Console.ReadLine();

            switch (mainChoice)
            {
                case "1":

                    User loggedUser = loginMenu.Show();

                    if (loggedUser == null)
                        break;

                    bool logout = false;

                    while (!logout)
                    {
                        switch (loggedUser.Role)
                        {
                            case "ADMIN":
                                logout = adminMenu.Show();
                                break;

                            case "RECEPTIONIST":
                                logout = receptionistMenu.Show();
                                break;

                            case "DOCTOR":
                                if (loggedUser.DoctorID == null)
                                {
                                    Console.WriteLine("Doctor not linked.");
                                    logout = true;
                                    break;
                                }

                                logout = doctorPanelMenu.Show(loggedUser.DoctorID.Value);
                                break;

                            default:
                                Console.WriteLine("Invalid role.");
                                logout = true;
                                break;
                        }
                    }

                    break;

                case "0":
                    exitApplication = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine("System closed.");
    }
}
