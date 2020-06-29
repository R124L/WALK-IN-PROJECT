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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Reservasi reservasi = new Reservasi();
            Tampilkan(Kamar.Instance);
            reservasi.ShowDialog();
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {
            Tampilkan(Kamar.Instance);
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            Tampilkan(CheckIn.Instance);
        }

        private void btnTamu_Click(object sender, EventArgs e)
        {
            Tampilkan(Tamu.Instance);
        }

        internal void Tampilkan(Control instance)
        {
            panelControl.Controls.Add(instance);
            instance.Dock = DockStyle.Fill;
            instance.BringToFront();
        }
    }
}
