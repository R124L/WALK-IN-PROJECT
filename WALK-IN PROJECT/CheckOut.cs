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
    public partial class CheckOut : UserControl
    {
        private static CheckOut _instance;
        public static CheckOut Instance
        {
            get
            {
                if (_instance == null) _instance = new CheckOut();
                return _instance;
            }
        }

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }
    }
}
