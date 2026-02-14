using System;
using HealthCare.Service;
using HealthCare.Models;

namespace HealthCare.Menu
{
    public class BillingMenu
    {
        private readonly BillingService _billingService;

        public BillingMenu(BillingService billingService)
        {
            _billingService = billingService;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n===== BILLING MODULE =====");
                Console.WriteLine("1. Create Bill");
                Console.WriteLine("2. Add Billing Item");
                Console.WriteLine("3. Record Payment");
                Console.WriteLine("4. View Bills by Patient");
                Console.WriteLine("0. Back");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": CreateBill(); break;
                    case "2": AddBillingItem(); break;
                    case "3": RecordPayment(); break;
                    case "4": ViewBillsByPatient(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

        private void CreateBill()
        {
            Console.Write("Appointment ID: "); int appointmentId = int.Parse(Console.ReadLine());
            Console.Write("Patient ID: "); int patientId = int.Parse(Console.ReadLine());
            Console.Write("Doctor ID: "); int doctorId = int.Parse(Console.ReadLine());
            Console.Write("Total Amount: "); decimal amount = decimal.Parse(Console.ReadLine());

            Billing bill = new()
            {
                AppointmentID = appointmentId,
                PatientID = patientId,
                DoctorID = doctorId,
                Amount = amount
            };

            int id = _billingService.CreateBill(bill);
            Console.WriteLine($"Bill created with ID: {id}");
        }

        private void AddBillingItem()
        {
            Console.Write("Billing ID: "); int billingId = int.Parse(Console.ReadLine());
            Console.Write("Item Description: "); string desc = Console.ReadLine();
            Console.Write("Item Amount: "); decimal amt = decimal.Parse(Console.ReadLine());

            _billingService.AddBillingItem(billingId, new BillingItem { Description = desc, Amount = amt });
            Console.WriteLine("Billing item added.");
        }

        private void RecordPayment()
        {
            Console.Write("Billing ID: "); int billingId = int.Parse(Console.ReadLine());
            Console.Write("Amount: "); decimal amt = decimal.Parse(Console.ReadLine());
            Console.Write("Payment Method: "); string method = Console.ReadLine();

            int paymentId = _billingService.AddPayment(new Payment
            {
                BillingID = billingId,
                Amount = amt,
                PaymentMethod = method
            });

            Console.WriteLine($"Payment recorded with ID: {paymentId}");
        }

        private void ViewBillsByPatient()
        {
            Console.Write("Patient ID: "); int patientId = int.Parse(Console.ReadLine());
            var bills = _billingService.GetBillsByPatient(patientId);

            if (bills.Count == 0)
            {
                Console.WriteLine("No bills found.");
                return;
            }

            foreach (var bill in bills)
            {
                Console.WriteLine($"BillID: {bill.BillingID}, AppointmentID: {bill.AppointmentID}, Amount: {bill.Amount}, CreatedAt: {bill.CreatedAt}");
            }
        }
    }
}
