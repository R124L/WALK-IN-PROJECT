﻿using System;
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
    public partial class Tamu: UserControl
    {
        private static Tamu _instance;
        public static Tamu Instance
        {
            get
            {
                if (_instance == null) _instance = new Tamu();
                return _instance;
            }
        }

        public Tamu()
        {
            InitializeComponent();
        }

        private void Tamu_Load(object sender, EventArgs e)
        {

        }
    }
}