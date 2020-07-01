using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WALK_IN_PROJECT
{
    public partial class Reservasi : Form
    {
        public Reservasi()
        {
            InitializeComponent();
        }

        private void Reservasi_Load(object sender, EventArgs e)
        {
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kirim_Click(object sender, EventArgs e)
        {
            DataReservasi dataReservasi = new DataReservasi();
            MainForm mainForm = new MainForm();
            string pengenal = "";
            string kodeReservasi = "K" + nomorKamar.Text;
            string admin = mainForm.txtUsername.Text;

            if (ktp.Checked)
            {
                pengenal = "KTP";
            }
            else if (sim.Checked)
            {
                pengenal = "SIM";
            }
            else if (passport.Checked)
            {
                pengenal = "Passport";
            }
            else if (kartuPelajar.Checked)
            {
                pengenal = "Kartu Pelajar";
            }

            dataReservasi.InsertTabelTamu(noId.Text, nama.Text, alamat.Text, telp.Text, email.Text, pengenal, nomorKamar.Text);
            dataReservasi.InsertTabelReservasi(kodeReservasi, noId.Text, "Rizal Iswandy");
            dataReservasi.UpdateKetersediaanKamar(nomorKamar.Text, "False");
            MessageBox.Show($"Terimakasih telah melakukan reservasi dengan: \nKode Reservasi {kodeReservasi}, atas nama {nama.Text}. \nHarga\t: {dataReservasi.ShowHarga(nomorKamar.Text)}", "RESERVASI SUKSES!");
            this.Close();
        }
    }
}
