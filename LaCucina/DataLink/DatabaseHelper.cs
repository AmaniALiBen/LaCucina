using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            "Server=localhost;Database=LaCucina;Trusted_Connection=True;";

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection conn =
                   new SqlConnection(connectionString))
            {
                conn.Open();

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn =
                   new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                return cmd.ExecuteNonQuery();
            }
        }

        public static int ExecuteScalar(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

               
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
            }
        }
    }
}

