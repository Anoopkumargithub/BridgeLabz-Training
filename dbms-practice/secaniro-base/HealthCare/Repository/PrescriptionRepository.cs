using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Connection;
using HealthCare.Exceptions;

namespace HealthCare.Repository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        public int AddPrescription(Prescription prescription)
        {
            string query = @"
                INSERT INTO Prescriptions
                (VisitID, Medication, Dosage, Frequency, Duration)
                VALUES (@VisitID, @Medication, @Dosage, @Frequency, @Duration);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@VisitID", prescription.VisitID);
                cmd.Parameters.AddWithValue("@Medication", prescription.Medication);
                cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Frequency", prescription.Frequency ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Duration", prescription.Duration ?? (object)DBNull.Value);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to add prescription.", ex);
            }
        }

        public List<Prescription> GetPrescriptionsByVisit(int visitId)
        {
            string query = @"
                SELECT p.*, 
                       pt.Name AS PatientName,
                       d.Name AS DoctorName
                FROM Prescriptions p
                INNER JOIN Visits v ON p.VisitID = v.VisitID
                INNER JOIN Patients pt ON v.PatientID = pt.PatientID
                INNER JOIN Doctors d ON v.DoctorID = d.DoctorID
                WHERE p.VisitID = @VisitID;";

            List<Prescription> prescriptions = new();

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@VisitID", visitId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                prescriptions.Add(new Prescription
                {
                    PrescriptionID = (int)reader["PrescriptionID"],
                    VisitID = (int)reader["VisitID"],
                    Medication = reader["Medication"].ToString(),
                    Dosage = reader["Dosage"]?.ToString(),
                    Frequency = reader["Frequency"]?.ToString(),
                    Duration = reader["Duration"]?.ToString(),
                    CreatedAt = (DateTime)reader["Created_At"],
                    UpdatedAt = (DateTime)reader["Updated_At"],
                    PatientName = reader["PatientName"].ToString(),
                    DoctorName = reader["DoctorName"].ToString()
                });
            }

            return prescriptions;
        }
    }
}
