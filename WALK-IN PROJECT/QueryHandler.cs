using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WALK_IN_PROJECT
{
    class QueryHandler
    {
        SqlConnection connection;
        string connectionString = "Data Source=WHO-KNOWS;Initial Catalog=hotel;Integrated Security=True;Pooling=False";

        public string property { get; set; }
        public string[] GetReaderValue(string connectionString, string query, int indexField)
        {
            List<string> list = new List<string>();
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(indexField));
                    }
                }
            }

            return list.ToArray();
        }

        public DataTable ShowReservasi()
        {
            string query = "SELECT KodeReservasi,Reservasi.NoIdTamu, Nama, CheckIn,CheckOut, Tamu.NoKamar, Biaya " +
                "FROM Reservasi INNER JOIN Tamu ON Reservasi.NoIdTamu = Tamu.NoIdTamu " +
                "INNER JOIN Kamar ON Tamu.NoKamar = Kamar.NoKamar; ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }

        }
        
        public DataTable ShowTamu()
        {
            string query = "SELECT NoIdTamu, Nama, Telp, Tamu.NoKamar, CheckIn, CheckOut, Fasilitas FROM Tamu " +
                "INNER JOIN Kamar ON Tamu.NoKamar = Kamar.NoKamar WHERE Tamu.Status = 'Tamu'";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data;
            }

        }

        public void CheckIn(string noId)
        {
            string query = "DELETE FROM Reservasi WHERE NoIdTamu = @idTamu; " +
                "UPDATE Tamu SET Status = 'Tamu' WHERE NoIdTamu = @idTamu; ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@idTamu", noId);
                command.ExecuteNonQuery();
            }
        }

        public void CheckOut(string noKamar)
        {
            string query = "DELETE FROM Tamu WHERE NoKamar = @idKamar; " +
                "UPDATE Kamar SET Tersedia = 'True' WHERE NoKamar = @idKamar; ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@idKamar", noKamar);
                command.ExecuteNonQuery();
            }
        }

        public void Cancel(string noId, string noKamar)
        {
            string query = "DELETE FROM Reservasi WHERE NoIdTamu = @idTamu; " +
                "DELETE FROM Tamu WHERE NoIdTamu = @idTamu; " +
                "UPDATE Kamar SET Tersedia = 'True' WHERE NoKamar = @noKamar; ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@idTamu", noId);
                command.Parameters.AddWithValue("@noKamar", noKamar);
                command.ExecuteNonQuery();
            }
        }
    }
}
