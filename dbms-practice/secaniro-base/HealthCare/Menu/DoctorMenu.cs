using System;
using HealthCare.Service;

namespace HealthCare.Menu
{
    public class DoctorMenu
    {
        private readonly DoctorService _doctorService;
        private readonly VisitService _visitService;

        public DoctorMenu(VisitService visitService)
        {
            _doctorService = new DoctorService();
            _visitService = visitService;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== DOCTOR MENU =====");
                Console.WriteLine("---- Doctor Management ----");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Update Doctor");
                Console.WriteLine("3. Get Doctor By ID");
                Console.WriteLine("4. Get Doctors By Speciality");
                Console.WriteLine("5. Delete Doctor");

                Console.WriteLine("\n---- Doctor Panel ----");
                Console.WriteLine("6. View My Visits");
                Console.WriteLine("7. Complete Visit");

                Console.WriteLine("0. Back");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        _doctorService.AddDoctor();
                        break;

                    case "2":
                        _doctorService.UpdateDoctor();
                        break;

                    case "3":
                        _doctorService.GetDoctorById();
                        break;

                    case "4":
                        _doctorService.GetDoctorsBySpeciality();
                        break;

                    case "5":
                        _doctorService.DeleteDoctor();
                        break;

                    case "6":
                        ViewDoctorVisits();
                        break;

                    case "7":
                        CompleteVisit();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void ViewDoctorVisits()
        {
            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            var visits = _visitService.GetVisitsByDoctor(doctorId);

            if (visits.Count == 0)
            {
                Console.WriteLine("No visits found.");
                return;
            }

            foreach (var visit in visits)
            {
                Console.WriteLine(
                    $"VisitID: {visit.VisitID}, " +
                    $"Patient: {visit.PatientName}, " +
                    $"Status: {visit.Status}, " +
                    $"Date: {visit.VisitDate}"
                );
            }
        }

        private void CompleteVisit()
        {
            Console.Write("Enter Visit ID: ");
            int visitId = int.Parse(Console.ReadLine());

            Console.Write("Enter Diagnosis: ");
            string diagnosis = Console.ReadLine();

            Console.Write("Enter Notes: ");
            string notes = Console.ReadLine();

            try
            {
                _visitService.CompleteVisit(visitId, diagnosis, notes);
                Console.WriteLine("Visit completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
