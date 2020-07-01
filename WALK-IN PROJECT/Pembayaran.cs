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
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {

        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            //DataReservasi dataReservasi = new DataReservasi();
            //dataReservasi.RemoveTabelReservasi(kodeReservasi.Text);
            this.Close();
        }

        private void Bayar_ValueChanged(object sender, EventArgs e)
        {
            Kembali.Value = Bayar.Value - Harga.Value;
        }
    }
}
