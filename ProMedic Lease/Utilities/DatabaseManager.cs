using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace ProMedic_Lease.Utilities
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                var dataTable = new DataTable();
                using (var adapter = new SqlDataAdapter(command))
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();
                var result = command.ExecuteNonQuery();
                return result;
            }
        }
    }
}