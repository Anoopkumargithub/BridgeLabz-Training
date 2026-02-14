using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Connection;
using HealthCare.Exceptions;

namespace HealthCare.Repository
{
    public class VisitRepository : IVisitRepository
    {
        public int CreateVisit(Visit visit)
        {
            string query = @"
                INSERT INTO Visits
                (AppointmentID, PatientID, DoctorID, Status)
                VALUES (@AppointmentID, @PatientID, @DoctorID, 'IN_PROGRESS');
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@AppointmentID", visit.AppointmentID);
                cmd.Parameters.AddWithValue("@PatientID", visit.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", visit.DoctorID);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    throw new ValidationException("Visit already exists for this appointment.");

                throw new DatabaseException("Failed to create visit.", ex);
            }
        }

        public Visit GetVisitById(int visitId)
        {
            string query = @"
                SELECT v.*, 
                       p.Name AS PatientName,
                       d.Name AS DoctorName
                FROM Visits v
                INNER JOIN Patients p ON v.PatientID = p.PatientID
                INNER JOIN Doctors d ON v.DoctorID = d.DoctorID
                WHERE v.VisitID = @VisitID;";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@VisitID", visitId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
                throw new NotFoundException("Visit not found.");

            return new Visit
            {
                VisitID = (int)reader["VisitID"],
                AppointmentID = (int)reader["AppointmentID"],
                PatientID = (int)reader["PatientID"],
                DoctorID = (int)reader["DoctorID"],
                Diagnosis = reader["Diagnosis"]?.ToString(),
                Notes = reader["Notes"]?.ToString(),
                Status = reader["Status"].ToString(),
                VisitDate = (DateTime)reader["VisitDate"],
                UpdatedAt = (DateTime)reader["Updated_At"],
                PatientName = reader["PatientName"].ToString(),
                DoctorName = reader["DoctorName"].ToString()
            };
        }

        public List<Visit> GetVisitsByDoctor(int doctorId)
        {
            string query = @"
                SELECT v.*, p.Name AS PatientName
                FROM Visits v
                INNER JOIN Patients p ON v.PatientID = p.PatientID
                WHERE v.DoctorID = @DoctorID
                ORDER BY v.VisitDate DESC;";

            List<Visit> visits = new();

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DoctorID", doctorId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                visits.Add(new Visit
                {
                    VisitID = (int)reader["VisitID"],
                    AppointmentID = (int)reader["AppointmentID"],
                    PatientID = (int)reader["PatientID"],
                    DoctorID = (int)reader["DoctorID"],
                    Diagnosis = reader["Diagnosis"]?.ToString(),
                    Notes = reader["Notes"]?.ToString(),
                    Status = reader["Status"].ToString(),
                    VisitDate = (DateTime)reader["VisitDate"],
                    PatientName = reader["PatientName"].ToString()
                });
            }

            return visits;
        }

        public List<Visit> GetVisitsByPatient(int patientId)
        {
            string query = @"
                SELECT v.*, d.Name AS DoctorName
                FROM Visits v
                INNER JOIN Doctors d ON v.DoctorID = d.DoctorID
                WHERE v.PatientID = @PatientID
                ORDER BY v.VisitDate DESC;";

            List<Visit> visits = new();

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PatientID", patientId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                visits.Add(new Visit
                {
                    VisitID = (int)reader["VisitID"],
                    AppointmentID = (int)reader["AppointmentID"],
                    PatientID = (int)reader["PatientID"],
                    DoctorID = (int)reader["DoctorID"],
                    Diagnosis = reader["Diagnosis"]?.ToString(),
                    Notes = reader["Notes"]?.ToString(),
                    Status = reader["Status"].ToString(),
                    VisitDate = (DateTime)reader["VisitDate"],
                    DoctorName = reader["DoctorName"].ToString()
                });
            }

            return visits;
        }

        public void CompleteVisit(int visitId, string diagnosis, string notes)
        {
            string query = @"
                UPDATE Visits
                SET Diagnosis = @Diagnosis,
                    Notes = @Notes,
                    Status = 'COMPLETED',
                    Updated_At = CURRENT_TIMESTAMP
                WHERE VisitID = @VisitID;";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Diagnosis", diagnosis);
            cmd.Parameters.AddWithValue("@Notes", notes);
            cmd.Parameters.AddWithValue("@VisitID", visitId);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows == 0)
                throw new NotFoundException("Visit not found.");
        }
    }
}
