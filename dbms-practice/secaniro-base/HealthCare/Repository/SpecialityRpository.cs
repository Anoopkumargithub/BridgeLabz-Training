using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using HealthCare.Models;
using HealthCare.Interfaces;
using HealthCare.Connection;
using HealthCare.Exceptions;

namespace HealthCare.Repository
{
    public class SpecialityRepository : ISpecialityRepository
    {
        public int AddSpeciality(string name)
    {
        string query = @"
        INSERT INTO Specialities (SpecialityName)
        VALUES (@SpecialityName);
        SELECT CAST(SCOPE_IDENTITY() AS INT);";

        using SqlConnection conn = DbConnection.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@SpecialityName", name);

        try
        {
            conn.Open();
            return (int)cmd.ExecuteScalar();
        }
        catch (SqlException ex)
        {
            throw new DatabaseException("Failed to add speciality", ex);
        }
    }

    public List<Speciality> GetAllSpecialities()
    {
        List<Speciality> list = new();

        string query = "SELECT * FROM Specialities";

        using SqlConnection conn = DbConnection.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);

        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Speciality(
                (int)reader["SpecialityID"],
                (string)reader["SpecialityName"]
            ));
        }

        return list;
    }

    public Speciality GetById(int specialityId)
    {
        string query = "SELECT * FROM Specialities WHERE SpecialityID = @Id";

        using SqlConnection conn = DbConnection.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Id", specialityId);
        conn.Open();

        using SqlDataReader reader = cmd.ExecuteReader();

        if (!reader.Read())
            throw new NotFoundException("Speciality not found");

        return new Speciality(
            (int)reader["SpecialityID"],
            (string)reader["SpecialityName"]
        );
    }

    public List<Speciality> SearchSpeciality(string keyword)
    {
        List<Speciality> list = new();

        string query = @"
        SELECT * FROM Specialities
        WHERE SpecialityName LIKE @Keyword";

        using SqlConnection conn = DbConnection.GetConnection();
        using SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

        conn.Open();
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new Speciality(
                (int)reader["SpecialityID"],
                (string)reader["SpecialityName"]
            ));
        }

        return list;
    }
    }
}
