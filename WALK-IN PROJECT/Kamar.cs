using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WALK_IN_PROJECT
{
    public partial class Kamar: UserControl
    {
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

        }
    }
}
