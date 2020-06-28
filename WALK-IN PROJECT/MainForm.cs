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
            tampilkan(Kamar.Instance);
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {

        }

        internal void tampilkan(Control instance)
        {
            panelControl.Controls.Add(instance);
            instance.Dock = DockStyle.Fill;
            instance.BringToFront();
        }
    }
}
