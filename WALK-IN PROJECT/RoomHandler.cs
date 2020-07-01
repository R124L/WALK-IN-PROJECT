using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WALK_IN_PROJECT
{
    class RoomHandler
    {
        string connectionString = "Data Source=WHO-KNOWS;Initial Catalog=hotel;Integrated Security=True;Pooling=False";
        string queryTersedia = "SELECT NoKamar FROM Kamar WHERE Tersedia = 'True'";
        string queryTidakTersedia = "SELECT NoKamar FROM Kamar WHERE Tersedia = 'False'";

        public void ColorTersedia(Control form)
        {

            foreach (Control control in form.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    QueryHandler queryHandler = new QueryHandler();
                    string[] nomorKamarTersedia = queryHandler.GetReaderValue(connectionString, queryTersedia, 0);
                    foreach (string tersedia in nomorKamarTersedia)
                    {
                        if (button.Text == tersedia)
                        {
                            button.Enabled = true;
                            button.BackColor = ColorTranslator.FromHtml("#18A05E");
                        }
                    }
                    string[] nomorTidakTersedia = queryHandler.GetReaderValue(connectionString, queryTidakTersedia, 0);
                    foreach (string tersedia in nomorTidakTersedia)
                    {
                        if (button.Text == tersedia)
                        {
                            button.Enabled = false;
                            button.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        public void CheckedColor(string tipeKamar, Control form, Color color, bool enabled)
        {
            string query = "SELECT NoKamar FROM Kamar WHERE Tipe = @tipeKamar  AND Tersedia = 'True'";
            SqlConnection connection;

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@tipeKamar", tipeKamar);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        foreach (Control control in form.Controls)
                        {
                            if (control is Button)
                            {
                                Button button = (Button)control;
                                if (button.Text == reader["NoKamar"].ToString())
                                {
                                    button.BackColor = color;
                                    button.Enabled = enabled;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
