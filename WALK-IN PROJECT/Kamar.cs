using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WALK_IN_PROJECT
{
    public partial class Kamar: UserControl
    {
        public bool kamarClick { get; set; }

        private static Kamar _instance;
        public static Kamar Instance
        {
            get
            {
                if (_instance == null) _instance = new Kamar();
                return _instance;
            }
        }

        public Kamar()
        {
            InitializeComponent();
        }

        private void Kamar_Load(object sender, EventArgs e)
        {
            kamarClick = true;
            RoomHandler roomHandler = new RoomHandler();
            roomHandler.ColorTersedia(this);

            tglCheckIn.Value = DateTime.Today;
            tglCheckOut.Value = DateTime.Today.AddDays(1);
        }

        private void book_Click(object sender, EventArgs e)
        {
            DataReservasi dataReservasi = new DataReservasi();
            RoomHandler roomHandler = new RoomHandler();
            DateTime checkIn = tglCheckIn.Value;
            DateTime checkOut = tglCheckOut.Value;
            string nomorKamar = NomorKamar();
            dataReservasi.InsertDataKamar(checkIn, checkOut, nomorKamar);

            Reservasi reservasi = new Reservasi();
            reservasi.nomorKamar.Text = nomorKamar;
            reservasi.ShowDialog();
            roomHandler.ColorTersedia(this);
            foreach (Control control in Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = true;
                }
            }
        }

        private void tipeKamar_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            RoomHandler roomHandler = new RoomHandler();
            if (!checkBox.Checked)
            {
                roomHandler.CheckedColor(checkBox.Text, this, Color.Gray, false);
            }
            else
            {
                roomHandler.CheckedColor(checkBox.Text, this, ColorTranslator.FromHtml("#18A05E"), true);
            }
        }

        private void kamar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == Color.DarkOrange)
            {
                button.BackColor = ColorTranslator.FromHtml("#18A05E");
                kamarClick = false;
            }
            else
            {
                button.BackColor = Color.DarkOrange;
                kamarClick = true;
            }
        }

        public string NomorKamar()
        {
            string nomorKamar = "";

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    if (button.BackColor == Color.DarkOrange)
                    {
                        nomorKamar = button.Text;
                    }
                }
            }

            return nomorKamar;
        }
    }
}
