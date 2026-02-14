using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Exceptions;
using HealthCare.Connection;

namespace HealthCare.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public void CreateAppointment(Appointment appointment)
        {
            string query = @"
                INSERT INTO Appointments
                (PatientID, DoctorID, AppointmentDate, AppointmentTime, Status)
                VALUES (@PatientID, @DoctorID, @AppointmentDate, @AppointmentTime, 'SCHEDULED');";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@AppointmentTime", appointment.AppointmentTime);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                    throw new ValidationException("Doctor already booked for this slot.");

                throw new DatabaseException("Failed to create appointment.", ex);
            }
        }

        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            string query = @"
                SELECT a.*, p.Name AS PatientName, d.Name AS DoctorName
                FROM Appointments a
                INNER JOIN Patients p ON a.PatientID = p.PatientID
                INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                WHERE a.DoctorID = @DoctorID
                ORDER BY a.AppointmentDate, a.AppointmentTime;";

            List<Appointment> appointments = new();

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DoctorID", doctorId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                appointments.Add(new Appointment
                {
                    AppointmentID = (int)reader["AppointmentID"],
                    PatientID = (int)reader["PatientID"],
                    DoctorID = (int)reader["DoctorID"],
                    AppointmentDate = (DateTime)reader["AppointmentDate"],
                    AppointmentTime = (TimeSpan)reader["AppointmentTime"],
                    Status = reader["Status"].ToString(),
                    PatientName = reader["PatientName"].ToString(),
                    DoctorName = reader["DoctorName"].ToString()
                });
            }

            return appointments;
        }

        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            string query = @"
                SELECT a.*, 
                       p.Name AS PatientName, 
                       d.Name AS DoctorName
                FROM Appointments a
                INNER JOIN Patients p ON a.PatientID = p.PatientID
                INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                WHERE a.PatientID = @PatientID
                ORDER BY a.AppointmentDate DESC, a.AppointmentTime DESC;";

            List<Appointment> appointments = new();

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@PatientID", patientId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                appointments.Add(new Appointment
                {
                    AppointmentID = (int)reader["AppointmentID"],
                    PatientID = (int)reader["PatientID"],
                    DoctorID = (int)reader["DoctorID"],
                    AppointmentDate = (DateTime)reader["AppointmentDate"],
                    AppointmentTime = (TimeSpan)reader["AppointmentTime"],
                    Status = reader["Status"].ToString(),
                    PatientName = reader["PatientName"].ToString(),
                    DoctorName = reader["DoctorName"].ToString(),
                    CreatedAt = (DateTime)reader["Created_At"],
                    UpdatedAt = (DateTime)reader["Updated_At"]
                });
            }

            return appointments;
        }


        public void UpdateStatus(int appointmentId, string status)
        {
            string query = @"
                UPDATE Appointments
                SET Status = @Status,
                    Updated_At = CURRENT_TIMESTAMP
                WHERE AppointmentID = @AppointmentID;";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows == 0)
                throw new NotFoundException("Appointment not found.");
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            string query = @"
                SELECT a.*, 
                       p.Name AS PatientName, 
                       d.Name AS DoctorName
                FROM Appointments a
                INNER JOIN Patients p ON a.PatientID = p.PatientID
                INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                WHERE a.AppointmentID = @AppointmentID;";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Appointment
                {
                    AppointmentID = (int)reader["AppointmentID"],
                    PatientID = (int)reader["PatientID"],
                    DoctorID = (int)reader["DoctorID"],
                    AppointmentDate = (DateTime)reader["AppointmentDate"],
                    AppointmentTime = (TimeSpan)reader["AppointmentTime"],
                    Status = reader["Status"].ToString(),
                    PatientName = reader["PatientName"].ToString(),
                    DoctorName = reader["DoctorName"].ToString(),
                    CreatedAt = (DateTime)reader["CreatedAt"],
                    UpdatedAt = (DateTime)reader["UpdatedAt"]
                };
            }

            throw new NotFoundException("Appointment not found.");
        }

        public void CancelAppointment(int appointmentId)
        {
            UpdateStatus(appointmentId, "CANCELLED");
        }

    }
}