using System;
using System.Collections.Generic;
using HealthCare.Models;

namespace HealthCare.Interfaces
{
    public interface IBillingRepository
    {

        int CreateBilling(Billing bill);

        void AddBillingItem(int billingId, BillingItem item);

        int AddPayment(Payment payment);

        List<Billing> GetBillsByPatient(int patientId);

    }
}