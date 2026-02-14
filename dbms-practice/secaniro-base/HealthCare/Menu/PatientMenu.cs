using System;
using HealthCare.Service;
using HealthCare.Models;
using System.Collections.Generic;

namespace HealthCare.Menu
{
    public class PatientMenu
    {
        private readonly PatientService _patientService;
        private readonly BillingService _billingService;

        public PatientMenu(PatientService patientService, BillingService billingService)
        {
            _patientService = patientService;
            _billingService = billingService;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== PATIENT MODULE =====");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Update Patient");
                Console.WriteLine("3. Search Patient");
                Console.WriteLine("4. Get Patient By ID");
                Console.WriteLine("5. View My Bills");
                Console.WriteLine("0. Back");
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
                        _patientService.SearchPatient();
                        break;

                    case "4":
                        _patientService.GetPatientById();
                        break;

                    case "5":
                        ViewBills();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void ViewBills()
        {
            Console.Write("Enter your Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            try
            {
                List<Billing> bills = _billingService.GetBillsByPatient(patientId);
                if (bills.Count == 0)
                {
                    Console.WriteLine("No bills found for this patient.");
                    return;
                }

                foreach (var bill in bills)
                {
                    Console.WriteLine($"\nBill ID: {bill.BillingID}, AppointmentID: {bill.AppointmentID}, Amount: {bill.Amount}, CreatedAt: {bill.CreatedAt}");
                    if (bill.Items.Count > 0)
                    {
                        Console.WriteLine("Items:");
                        foreach (var item in bill.Items)
                        {
                            Console.WriteLine($" - {item.Description}: {item.Amount}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving bills: {ex.Message}");
            }
        }
    }
}
