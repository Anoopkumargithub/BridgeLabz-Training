using System;
using Microsoft.Data.SqlClient;
using HealthCare.Interfaces;
using HealthCare.Models;
using HealthCare.Connection;

namespace HealthCare.Repository
{   
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
    {
        using (SqlConnection conn = DbConnection.GetConnection())
        {
            string query = @"INSERT INTO Users 
                            (Username, PasswordHash, Role, DoctorID)
                            VALUES (@Username, @PasswordHash, @Role, @DoctorID)";
    
            SqlCommand cmd = new SqlCommand(query, conn);
    
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
            cmd.Parameters.AddWithValue("@Role", user.Role);
    
            if (user.DoctorID.HasValue)
                cmd.Parameters.AddWithValue("@DoctorID", user.DoctorID.Value);
            else
                cmd.Parameters.AddWithValue("@DoctorID", DBNull.Value);
    
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

        public User GetByUsername(string username)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        Role = reader["Role"].ToString(),
                        DoctorID = reader["DoctorID"] == DBNull.Value ? null : (int?)reader["DoctorID"]
                    };
                }
            }

            return null;
        }
    }
}
