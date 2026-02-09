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
        // Add new Doctor
        public int AddDoctor(Doctor doctor)
        {
            string query = @"
            INSERT INTO Doctors 
            (Name, SpecialityID, Contact, Email, ConsultationFee, Is_Active)
            VALUES
            (@Name, @SpecialityID, @Contact, @Email, @ConsultationFee, 1);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", doctor.Name);
            cmd.Parameters.AddWithValue("@SpecialityID", doctor.SpecialityID);
            cmd.Parameters.AddWithValue("@Contact", doctor.Contact);
            cmd.Parameters.AddWithValue("@Email", doctor.Email);
            cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);

            conn.Open();
            return (int)cmd.ExecuteScalar();
        }

        // Update Doctor
        public bool UpdateDoctor(Doctor doctor)
        {
            string query = @"
            UPDATE Doctors
            SET Contact = @Contact,
                Email = @Email,
                ConsultationFee = @ConsultationFee
            WHERE DoctorID = @DoctorID;";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Contact", doctor.Contact);
            cmd.Parameters.AddWithValue("@Email", doctor.Email);
            cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);
            cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorId);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        // Get doctor by ID
        public Doctor GetDoctorById(int doctorId)
        {
            string query = @"
            SELECT * FROM Doctors
            WHERE DoctorID = @DoctorID;";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DoctorID", doctorId);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
                throw new NotFoundException("Doctor not found");

            return new Doctor(
                (int)reader["DoctorID"],
                (string)reader["Name"],
                (int)reader["SpecialityID"],
                (string)reader["Contact"],
                (string)reader["Email"],
                (decimal)reader["ConsultationFee"],
                (bool)reader["Is_Active"]
            );
        }

        // Get doctors by speciality
        public List<Doctor> GetDoctorsBySpeciality(string specialityName)
        {
            string query = @"
            SELECT d.*
            FROM Doctors d
            INNER JOIN Specialities s
                ON d.SpecialityID = s.SpecialityID
            WHERE s.SpecialityName = @SpecialityName
              AND d.Is_Active = 1;";

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
                    (string)reader["Name"],
                    (int)reader["SpecialityID"],
                    (string)reader["Contact"],
                    (string)reader["Email"],
                    (decimal)reader["ConsultationFee"],
                    (bool)reader["Is_Active"]
                ));
            }

            return doctors;
        }

        // Soft delete doctor
        public bool DeleteDoctor(int doctorId)
        {
            string query = @"
            UPDATE Doctors 
            SET Is_Active = 0
            WHERE DoctorID = @DoctorID;";

            using SqlConnection conn = DbConnection.GetConnection();
            using SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DoctorID", doctorId);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
