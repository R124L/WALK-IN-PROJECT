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
        public bool logout { get; set; }
        public string username { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Tampilkan(Kamar.Instance);
            txtUsername.Text = username + " (Admin)";
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {
            Tampilkan(Kamar.Instance);
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            Tampilkan(CheckIn.Instance);
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            Tampilkan(CheckOut.Instance);
        }

        internal void Tampilkan(Control instance)
        {
            panelControl.Controls.Add(instance);
            instance.Dock = DockStyle.Fill;
            instance.BringToFront();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
