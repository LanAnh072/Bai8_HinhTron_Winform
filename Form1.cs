﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_HinhTron_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double r = double.Parse(txtBK.Text);
            lblKQ.Text = "- Diện tích: " + dt(r) + "\n- Chu vi: " + cv(r);
        }
        double cv(double r) { return 2 * Math.PI * r; }
        double dt(double r) { return Math.PI * r * r; }

    }
}
