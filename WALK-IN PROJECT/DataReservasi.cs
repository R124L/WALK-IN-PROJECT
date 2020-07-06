using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WALK_IN_PROJECT
{
    class DataReservasi
    {
        SqlConnection connection;
        string connectionString = "Data Source=WHO-KNOWS;Initial Catalog=hotel;Integrated Security=True;Pooling=False";

        public void InsertDataKamar(DateTime checkIn, DateTime checkOut, string noKamar)
        {
            string query = "INSERT INTO Tamu (NoIdTamu, CheckIn, CheckOut, NoKamar, Status) VALUES (@idSementara, @checkIn, @checkOut, @noKamar, 'Reservasi');";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@idSementara", noKamar);
                command.Parameters.AddWithValue("@checkIn", checkIn);
                command.Parameters.AddWithValue("@checkOut", checkOut);
                command.Parameters.AddWithValue("@noKamar", noKamar);
                command.ExecuteNonQuery();
            }
        }
        public void InsertTabelTamu(string noId, string nama, string alamat, string telp, string email, string pengenal, string noKamar)
        {
            string query = "UPDATE Tamu SET " +
                "NoIdTamu = @noId, " +
                "Nama = @nama, " +
                "Alamat = @alamat, " +
                "Telp = @telp, " +
                "Email = @email, " +
                "TandaPengenal = @pengenal " +
                "WHERE NoKamar = @noKamar; ";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@noId", noId);
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@alamat", alamat);
                command.Parameters.AddWithValue("@telp", telp);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@pengenal", pengenal);
                command.Parameters.AddWithValue("@noKamar", noKamar);
                command.ExecuteNonQuery();
            }
        }
        public void InsertTabelReservasi(string kodeReservasi, string noId, string admin)
        {
            string query = "INSERT INTO Reservasi (KodeReservasi, NoIdTamu, UsernameAdmin) VALUES (@kodeReservasi, @noId, @admin);";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@noId", noId);
                command.Parameters.AddWithValue("@kodeReservasi", kodeReservasi);
                command.Parameters.AddWithValue("@admin", admin);
                command.ExecuteNonQuery();
            }
        }
        public int ShowHarga(string noKamar)
        {
            Kamar kamar = new Kamar();
            DateTime date1 = kamar.tglCheckIn.Value;
            DateTime date2 = kamar.tglCheckOut.Value;
            string query = "SELECT Harga FROM Kamar WHERE NoKamar = @noKamar;";
            int harga = 0;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@noKamar", noKamar);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int lamaMenginap = (int)date2.Subtract(date1).TotalDays;
                    while (reader.Read())
                    {
                        harga = Convert.ToInt32(reader["Harga"]) * lamaMenginap; 
                    }
                    return harga;
                }
            }
        }
        public void RemoveTabelReservasi(string kodeReservasi)
        {
            string query = "DELETE FROM Reservasi WHERE KodeReservasi = @kodeReservasi";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@kodeReservasi", kodeReservasi);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateKetersediaanKamar(string nomorKamar, string aktif)
        {
            string query = "UPDATE Kamar SET Tersedia = @aktif WHERE NoKamar = @nomorKamar";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@aktif", aktif);
                command.Parameters.AddWithValue("@nomorKamar", nomorKamar);
                command.ExecuteNonQuery();
            }
        }
    }
}
