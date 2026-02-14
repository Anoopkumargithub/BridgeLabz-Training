using System;
using HealthCare.Menu;
using HealthCare.Service;
using HealthCare.Exceptions;

namespace HealthCare.Menu
{
    public class ReceptionistMenu
    {
        private readonly AppointmentService _appointmentService;
        private readonly PatientService _patientService;
        private readonly VisitService _visitService;

        public ReceptionistMenu(
            AppointmentService appointmentService,
            PatientService PatientService)
        {
            _appointmentService = appointmentService;
            _patientService = PatientService;
        }

        public bool Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== RECEPTIONIST MENU =====");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Update Patient");
                Console.WriteLine("3. Create Appointment");
                Console.WriteLine("4. View Patient Appointments");
                Console.WriteLine("5. StartVisit");
                Console.WriteLine("6. Cancel Appointment");
                Console.WriteLine("0. Logout");

                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _patientService.AddPatient();
                        break;

                    case "2":
                        _patientService.UpdatePatient();
                        break;

                    case "3":
                        CreateAppointment();
                        break;

                    case "4":
                        ViewPatientAppointments();
                        break;

                    case "5":
                        StartVisit();
                        break;

                    case "6":
                        CancelAppointment();
                        break;

                    case "0":
                        return true;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

                private void CreateAppointment()
        {
           try
           {
               Console.Write("Patient ID: ");
               int patientId = int.Parse(Console.ReadLine());

               Console.Write("Doctor ID: ");
               int doctorId = int.Parse(Console.ReadLine());

               Console.Write("Date (yyyy-mm-dd): ");
               DateTime date = DateTime.Parse(Console.ReadLine());

               Console.Write("Time (HH:mm): ");
               TimeSpan time = TimeSpan.Parse(Console.ReadLine());

               _appointmentService.CreateAppointment(
                   patientId, doctorId, date, time);

               Console.WriteLine("Appointment scheduled successfully.");
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Error: {ex.Message}");
           }
        }

        private void ViewPatientAppointments()
        {
            Console.Write("Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());
        
            var appointments =
                _appointmentService.GetAppointmentsByPatient(patientId);
        
            if (appointments.Count == 0)
            {
                Console.WriteLine("No appointments found.");
                return;
            }
        
            foreach (var a in appointments)
            {
                Console.WriteLine(
                    $"{a.AppointmentID} | {a.AppointmentDate:yyyy-MM-dd} | {a.AppointmentTime} | Dr.{a.DoctorName} | {a.        Status}");
            }
        }
        
        
        private void CancelAppointment()
        {
            Console.Write("Appointment ID: ");
            int id = int.Parse(Console.ReadLine());
        
            _appointmentService.CancelAppointment(id);
        
            Console.WriteLine("Appointment cancelled.");
        }

        private void StartVisit()
        {
            Console.Write("Enter Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());

            try
            {
                int visitId = _visitService.StartVisit(appointmentId);
                Console.WriteLine($"Visit started successfully. Visit ID: {visitId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        


    }
}