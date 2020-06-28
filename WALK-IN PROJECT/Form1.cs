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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelHeader.Size = new Size(this.MaximumSize.Width, panelHeader.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
