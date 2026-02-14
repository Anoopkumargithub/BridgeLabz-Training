using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthCare.Models;
using HealthCare.Connection;
using HealthCare.Exceptions;
using HealthCare.Interfaces;

namespace HealthCare.Repository
{
    public class BillingRepository : IBillingRepository
    {
        // Add a new bill
        public int CreateBilling(Billing bill)
        {
            string query = @"
                INSERT INTO Billing (AppointmentID, PatientID, DoctorID, Amount)
                VALUES (@AppointmentID, @PatientID, @DoctorID, @Amount);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@AppointmentID", bill.AppointmentID);
                cmd.Parameters.AddWithValue("@PatientID", bill.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", bill.DoctorID);
                cmd.Parameters.AddWithValue("@Amount", bill.Amount);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to create billing.", ex);
            }
        }

        // Add billing items
        public void AddBillingItem(int billingId, BillingItem item)
        {
            string query = @"
                INSERT INTO Billing_Items (BillingID, Description, Amount)
                VALUES (@BillingID, @Description, @Amount);";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@BillingID", billingId);
                cmd.Parameters.AddWithValue("@Description", item.Description ?? "");
                cmd.Parameters.AddWithValue("@Amount", item.Amount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to add billing item.", ex);
            }
        }

        // Record payment
        public int AddPayment(Payment payment)
        {
            string query = @"
                INSERT INTO Payments (BillingID, Amount, PaymentMethod, PaymentStatus)
                VALUES (@BillingID, @Amount, @PaymentMethod, @PaymentStatus);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@BillingID", payment.BillingID);
                cmd.Parameters.AddWithValue("@Amount", payment.Amount);
                cmd.Parameters.AddWithValue("@PaymentMethod", payment.PaymentMethod ?? "");
                cmd.Parameters.AddWithValue("@PaymentStatus", payment.PaymentStatus ?? "PENDING");

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to add payment.", ex);
            }
        }

        // Get bills by patient
        public List<Billing> GetBillsByPatient(int patientId)
        {
            string query = @"
                SELECT * FROM Billing
                WHERE PatientID = @PatientID;";

            List<Billing> bills = new();
            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PatientID", patientId);

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bills.Add(new Billing
                    {
                        BillingID = (int)reader["BillingID"],
                        AppointmentID = (int)reader["AppointmentID"],
                        PatientID = (int)reader["PatientID"],
                        DoctorID = (int)reader["DoctorID"],
                        Amount = (decimal)reader["Amount"],
                        CreatedAt = (DateTime)reader["Created_At"],
                        UpdatedAt = (DateTime)reader["Updated_At"]
                    });
                }
                return bills;
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to retrieve bills.", ex);
            }
        }
    }
}
