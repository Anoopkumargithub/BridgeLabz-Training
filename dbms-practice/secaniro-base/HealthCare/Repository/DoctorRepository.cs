using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Exceptions;
using HealthCare.Connection;

namespace HealthCare.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        // ===========================
        // Add Doctor
        // ===========================
        public int AddDoctor(Doctor doctor)
        {
            if (doctor == null)
                throw new ValidationException("Doctor data cannot be null.");

            string query = @"
                INSERT INTO Doctors 
                (Name, SpecialityID, Contact, Email, ConsultationFee, Is_Active)
                VALUES
                (@Name, @SpecialityID, @Contact, @Email, @ConsultationFee, 1);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@SpecialityID", doctor.SpecialityID);
                cmd.Parameters.AddWithValue("@Contact", doctor.Contact ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", doctor.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);

                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to add doctor.", ex);
            }
        }

        // ===========================
        // Update Doctor
        // ===========================
        public bool UpdateDoctor(Doctor doctor)
        {
            if (doctor == null || doctor.DoctorId <= 0)
                throw new ValidationException("Invalid doctor data.");

            string query = @"
                UPDATE Doctors
                SET Contact = @Contact,
                    Email = @Email,
                    ConsultationFee = @ConsultationFee,
                    Updated_At = CURRENT_TIMESTAMP
                WHERE DoctorID = @DoctorID;";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Contact", doctor.Contact ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", doctor.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);
                cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                    throw new NotFoundException("Doctor not found.");

                return true;
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to update doctor.", ex);
            }
        }

        // ===========================
        // Get Doctor By ID
        // ===========================
        public Doctor GetDoctorById(int doctorId)
        {
            if (doctorId <= 0)
                throw new ValidationException("Invalid doctor ID.");

            string query = @"
                SELECT d.*, s.SpecialityName
                FROM Doctors d
                INNER JOIN Specialities s
                    ON d.SpecialityID = s.SpecialityID
                WHERE d.DoctorID = @DoctorID
                AND d.Is_Active = 1;";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@DoctorID", doctorId);

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                    throw new NotFoundException("Doctor not found.");

                return new Doctor(
                    (int)reader["DoctorID"],
                    reader["Name"].ToString(),
                    (int)reader["SpecialityID"],
                    reader["SpecialityName"].ToString(),
                    reader["Contact"]?.ToString(),
                    reader["Email"]?.ToString(),
                    (decimal)reader["ConsultationFee"],
                    (bool)reader["Is_Active"]
                );
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to retrieve doctor.", ex);
            }
        }

        // ===========================
        // Get Doctors By Speciality
        // ===========================
        public List<Doctor> GetDoctorsBySpeciality(string specialityName)
        {
            if (string.IsNullOrWhiteSpace(specialityName))
                throw new ValidationException("Speciality name cannot be empty.");

            string query = @"
                SELECT d.DoctorID,
                       d.Name,
                       d.SpecialityID,
                       s.SpecialityName,
                       d.Contact,
                       d.Email,
                       d.ConsultationFee,
                       d.Is_Active
                FROM Doctors d
                INNER JOIN Specialities s 
                    ON d.SpecialityID = s.SpecialityID
                WHERE s.SpecialityName = @SpecialityName
                  AND d.Is_Active = 1;";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@SpecialityName", specialityName);

                List<Doctor> doctors = new();

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doctors.Add(new Doctor(
                        (int)reader["DoctorID"],
                        reader["Name"].ToString(),
                        (int)reader["SpecialityID"],
                        reader["SpecialityName"].ToString(),
                        reader["Contact"]?.ToString(),
                        reader["Email"]?.ToString(),
                        (decimal)reader["ConsultationFee"],
                        (bool)reader["Is_Active"]
                    ));
                }

                if (doctors.Count == 0)
                    throw new NotFoundException("No doctors found for this speciality.");

                return doctors;
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to retrieve doctors by speciality.", ex);
            }
        }

        // ===========================
        // Soft Delete Doctor
        // ===========================
        public bool DeleteDoctor(int doctorId)
        {
            if (doctorId <= 0)
                throw new ValidationException("Invalid doctor ID.");

            string query = @"
                UPDATE Doctors 
                SET Is_Active = 0,
                    Updated_At = CURRENT_TIMESTAMP
                WHERE DoctorID = @DoctorID;";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@DoctorID", doctorId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                    throw new NotFoundException("Doctor not found.");

                return true;
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to delete doctor.", ex);
            }
        }

        // ===========================
        // Get All Active Doctors
        // ===========================
        public List<Doctor> GetAllDoctors()
        {
            string query = @"
                SELECT d.*, s.SpecialityName
                FROM Doctors d
                INNER JOIN Specialities s
                    ON d.SpecialityID = s.SpecialityID
                WHERE d.Is_Active = 1;";

            try
            {
                using SqlConnection conn = DbConnection.GetConnection();
                using SqlCommand cmd = new SqlCommand(query, conn);

                List<Doctor> doctors = new();

                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doctors.Add(new Doctor(
                        (int)reader["DoctorID"],
                        reader["Name"].ToString(),
                        (int)reader["SpecialityID"],
                        reader["SpecialityName"].ToString(),
                        reader["Contact"]?.ToString(),
                        reader["Email"]?.ToString(),
                        (decimal)reader["ConsultationFee"],
                        (bool)reader["Is_Active"]
                    ));
                }

                return doctors;
            }
            catch (SqlException ex)
            {
                throw new DatabaseException("Failed to retrieve doctors.", ex);
            }
        }
    }
}
