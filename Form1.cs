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

        private void btnCV_Click(object sender, EventArgs e)
        {
            double cv;
            double r = Convert.ToDouble(txtBK.Text);
            cv = 2 * Math.PI * r;
            txtKQ.Text = cv.ToString();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            double dt;
            double r = Convert.ToDouble(txtBK.Text);
            dt = Math.PI * r * r;
            txtKQ.Text = dt.ToString();
        }
    }
}
