using System;
using System.Data;
using System.Data.SqlClient;

namespace StockPro
{
    public class DBHelper
    {
        // ============================================================
        // CHANGE THIS if your SQL Server instance name is different
        // ============================================================
        private static string connectionString =
            "Server=.\\SQLEXPRESS;Database=StockProDB;Integrated Security=True;";

        // Returns an open connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        // Run INSERT / UPDATE / DELETE — returns rows affected
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        // Run SELECT — returns a DataTable
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Run SELECT — returns a single value (for COUNT, SUM, etc.)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        // Test the connection — used on app startup
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection con = GetConnection())
                    return con.State == ConnectionState.Open;
            }
            catch
            {
                return false;
            }
        }
    }
}