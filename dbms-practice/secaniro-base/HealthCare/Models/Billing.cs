using System;
using System.Collections.Generic;

namespace HealthCare.Models
{
    public class Billing
    {
        public int BillingID { get; set; }
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<BillingItem> Items { get; set; } = new List<BillingItem>();
    }

    public class BillingItem
    {
        public int ItemID { get; set; }
        public int BillingID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }

    public class Payment
    {
        public int PaymentID { get; set; }
        public int BillingID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; } = "PENDING";
    }
}
