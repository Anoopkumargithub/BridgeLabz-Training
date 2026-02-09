using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Connection;
using HealthCare.Exceptions;

namespace HealthCare.Repository
    {

    class PatientRepository : IPatientRepository
    {
       // Add Patient
       public int AddPatient(Patient patient)
       {
           using SqlConnection connection = DbConnection.GetConnection();

           string insertQuery = @"
           INSERT INTO Patients(Name, DateOfBirth, Contact, Address,   BloodGroup,Email,Gender,Is_Active ) Values (
           @Name, @DateOfBirth, @Contact, @Address, @BloodGroup,   @Email, @Gender, @Is_Active);
           
           SELECT CAST(SCOPE_IDENTITY() AS INT);
           ";

           using SqlCommand insertCommand = new SqlCommand (insertQuery, connection);
           insertCommand.Parameters.AddWithValue("@Name", patient. Name);
           insertCommand.Parameters.AddWithValue("@DateOfBirth",   patient.DateOfBirth);
           insertCommand.Parameters.AddWithValue("@Contact", patient.  Contact);
           insertCommand.Parameters.AddWithValue("@Address", patient.  Address);
           insertCommand.Parameters.AddWithValue("@BloodGroup",    patient.BloodGroup);
           insertCommand.Parameters.AddWithValue("@Email", patient.    Email);
           insertCommand.Parameters.AddWithValue("@Gender", patient.   Gender);
           insertCommand.Parameters.AddWithValue("@Is_Active",     patient.IsActive);

           try
           {
                connection.Open();
               int patientId = (int)insertCommand.ExecuteScalar();
               return patientId;
           }
           catch (SqlException ex)
           {
                throw new DatabaseException("Failed to add patient.", ex);
           }
       }

       //  Update Patient
       public bool UpdatePatient(Patient patient)
       {
           using SqlConnection connection = DbConnection.GetConnection();

           string updateQuery = @"
           UPDATE Patients
           SET  Contact = @Contact,
               Address = @Address,
               Email = @Email
           WHERE PatientId = @PatientId";

           using SqlCommand updateCommand = new SqlCommand(updateQuery,connection);

          updateCommand.Parameters.AddWithValue("@Contact", patient.Contact);
          updateCommand.Parameters.AddWithValue("@Address", patient.Address);
          updateCommand.Parameters.AddWithValue("@Email", patient.Email);
          updateCommand.Parameters.AddWithValue("@PatientId", patient.PatientId);

           try
           {
            connection.Open();
           int rows = updateCommand.ExecuteNonQuery();
           connection.Close();
           return rows > 0;
           }catch(SqlException ex)
           {
            throw new DatabaseException("Failed to update patient",ex);
           }
       }

       // search Patient by name or contact
       public List<Patient> SearchPatient(string keyword)
       {
           List<Patient> patients = new List<Patient>();

           string searchQuery  = @"
           SELECT * FROM Patients
           WHERE Name LIKE @Keyword OR Contact LIKE @Keyword";

           using SqlConnection connection = DbConnection.GetConnection();
           
           using SqlCommand searchCommand = new SqlCommand(searchQuery, connection);

           searchCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

           try
           {
                connection.Open();
                using SqlDataReader reader = searchCommand.ExecuteReader();        
                while(reader.Read())
                {
                    patients.Add(new Patient(
                        (int)reader["PatientId"], 
                        (string)reader["Name"],
                        (string)reader["Email"], 
                        (string)reader["Gender"], 
                        (DateTime)reader["DateOfBirth"], 
                        (string)reader["BloodGroup"], 
                        (string)reader["Contact"], 
                        (string)reader["Address"],
                        (bool)reader["Is_Active"]
                        ));
                }
                connection.Close();
                return patients;
           }catch(SqlException ex)
           {
            throw new DatabaseException($"Failed to Search Patient", ex);
           }
       }

       // get Patient by Id

       public Patient GetPatientById(int patientId)
       {
           string searchQuery  = @"
           SELECT * FROM Patients
           WHERE PatientId = @PatientId";

           using SqlConnection connection = DbConnection.GetConnection();
           
           using SqlCommand searchCommand = new SqlCommand(searchQuery, connection);

           searchCommand.Parameters.AddWithValue("@PatientId", patientId);

           try
           {
                connection.Open();
               using SqlDataReader reader = searchCommand.ExecuteReader();
               if (!reader.Read())
               {
                    throw new NotFoundException($"Patient with ID {patientId} not found.");
               }
               Patient patient = null;
               patient = new Patient(
                    (int)reader["PatientId"],
                   (string)reader["Name"],
                   (string)reader["Email"],
                   (string)reader["Gender"],
                   (DateTime)reader["DateOfBirth"],
                   (string)reader["BloodGroup"],
                   (string)reader["Contact"],
                   (string)reader["Address"],
                   (bool)reader["Is_Active"]
               );
               return patient;
           }
           catch (SqlException ex)
           {
                throw new DatabaseException("Failed to fetch patient.",
           ex);
           }
       }

       // delete Patient (is_Active = 0)
       public bool DeletePatient(int patientId)
        {
            using SqlConnection connection = DbConnection.      GetConnection();

            string query = @"
            UPDATE Patients
            SET Is_Active = 0
            WHERE PatientId = @PatientId";

            using SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PatientId", patientId);

            connection.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
        
    }
}