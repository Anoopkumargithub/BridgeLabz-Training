using System;
using System.Collections.Generic;
using HealthCare.Models;
using HealthCare.Interfaces;

namespace HealthCare.Service
{
    public class BillingService
    {
        private readonly IBillingRepository _billingRepo;

        public BillingService(IBillingRepository billingRepo)
        {
            _billingRepo = billingRepo;
        }

        public int CreateBill(Billing bill)
        {
            return _billingRepo.CreateBilling(bill);
        }

        public void AddBillingItem(int billingId, BillingItem item)
        {
            _billingRepo.AddBillingItem(billingId, item);
        }

        public int AddPayment(Payment payment)
        {
            return _billingRepo.AddPayment(payment);
        }

        public List<Billing> GetBillsByPatient(int patientId)
        {
            return _billingRepo.GetBillsByPatient(patientId);
        }
    }
}
