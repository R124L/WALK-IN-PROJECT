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
        QueryHandler queryHandler = new QueryHandler();

        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            checkInTable.DataSource = queryHandler.ShowReservasi();
        }

        private void btnCkeckIn_Click(object sender, EventArgs e)
        {
            string noId = checkInTable.SelectedCells[1].Value.ToString();
            queryHandler.CheckIn(noId);
            checkInTable.DataSource = queryHandler.ShowReservasi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            string noId = checkInTable.SelectedCells[1].Value.ToString();
            string noKamar = checkInTable.SelectedCells[5].Value.ToString();
            queryHandler.Cancel(noId, noKamar);
            checkInTable.DataSource = queryHandler.ShowReservasi();
        }


    }
}
