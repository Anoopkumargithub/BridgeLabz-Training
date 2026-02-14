using System;
using HealthCare.Service;

namespace HealthCare.Menu
{
    public class DoctorPanelMenu
    {
        private readonly VisitService _visitService;
        private readonly PrescriptionService _prescriptionService;

        public DoctorPanelMenu(VisitService visitService, PrescriptionService prescriptionService)
        {
            _visitService = visitService;
            _prescriptionService = prescriptionService;
        }

        public bool Show(int doctorId)
        {
            while (true)
            {
                Console.WriteLine("\n===== DOCTOR PANEL =====");
                Console.WriteLine("1. View My Visits");
                Console.WriteLine("2. Complete Visit");
                Console.WriteLine("3. Add Prescription");
                Console.WriteLine("4. View Prescriptions by Visit");
                Console.WriteLine("0. Logout");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": ViewDoctorVisits(doctorId); break;
                    case "2": CompleteVisit(doctorId); break;
                    case "3": AddPrescription(doctorId); break;
                    case "4": ViewPrescriptionsByVisit(doctorId); break;
                    case "0": return true;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        private void ViewDoctorVisits(int doctorId)
        {
            var visits = _visitService.GetVisitsByDoctor(doctorId);
            if (visits.Count == 0)
            {
                Console.WriteLine("No visits found.");
                return;
            }

            foreach (var visit in visits)
            {
                Console.WriteLine($"VisitID: {visit.VisitID}, Patient: {visit.PatientName}, Status: {visit.Status}, Date: {visit.VisitDate}");
            }
        }

        private void CompleteVisit(int doctorId)
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

        private void AddPrescription(int doctorId)
        {
            Console.Write("Enter Visit ID: ");
            int visitId = int.Parse(Console.ReadLine());

            Console.Write("Medication: ");
            string medication = Console.ReadLine();

            Console.Write("Dosage: ");
            string dosage = Console.ReadLine();

            Console.Write("Frequency: ");
            string frequency = Console.ReadLine();

            Console.Write("Duration: ");
            string duration = Console.ReadLine();

            try
            {
                int id = _prescriptionService.AddPrescription(visitId, medication, dosage, frequency, duration);
                Console.WriteLine($"Prescription added. ID: {id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void ViewPrescriptionsByVisit(int doctorId)
        {
            Console.Write("Enter Visit ID: ");
            int visitId = int.Parse(Console.ReadLine());

            var prescriptions = _prescriptionService.GetPrescriptionsByVisit(visitId);
            if (prescriptions.Count == 0)
            {
                Console.WriteLine("No prescriptions found for this visit.");
                return;
            }

            foreach (var p in prescriptions)
            {
                Console.WriteLine($"PrescriptionID: {p.PrescriptionID}, Medication: {p.Medication}, Dosage: {p.Dosage}, Frequency: {p.Frequency}, Duration: {p.Duration}");
            }
        }
    }
}
