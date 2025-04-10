using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace TicketVendorMachine.Models
{
    internal class DatabaseHelper
    {
        private static string connectionString = "Server=MINHHIEU\\SQLEXPRESS;Database=TicketDB;Trusted_Connection=True;";


        public static DataTable GetStations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT StationName FROM Stations";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int GetFare(string from, string to)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Price FROM FareMatrix WHERE FromStation = @from AND ToStation = @to";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void SaveTicket(string from, string to, int fare, string method)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Tickets (FromStation, ToStation, Fare, PaymentMethod) VALUES (@from, @to, @fare, @method)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);
                cmd.Parameters.AddWithValue("@fare", fare);
                cmd.Parameters.AddWithValue("@method", method);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
