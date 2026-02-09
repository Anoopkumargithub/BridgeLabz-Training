using Microsoft.Data.SqlClient;

namespace HealthCare.Connection
    {

    public static class DbConnection
    {
       public static readonly string _connectionString = "Server=localhost,1433;" +
           "Database=HEALTHCARE_DB;" +
           "User Id=sa;" +
           "Password=Admin@123;" +
           "TrustServerCertificate=True;";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}