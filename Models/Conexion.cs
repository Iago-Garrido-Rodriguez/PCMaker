using Microsoft.Data.SqlClient;

namespace PCMaker.Models
{
    public  class Conexion 
    {
        private readonly string connectionString = "Data Source=localhost;User ID=sa;Password=********;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Conexion(string value)
        {
            value = connectionString;
        }
        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

    }
}