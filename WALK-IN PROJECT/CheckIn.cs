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
    public partial class CheckIn : UserControl
    {
        private static CheckIn _instance;
        public static CheckIn Instance
        {
            get
            {
                if (_instance == null) _instance = new CheckIn();
                return _instance;
            }
        }
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
