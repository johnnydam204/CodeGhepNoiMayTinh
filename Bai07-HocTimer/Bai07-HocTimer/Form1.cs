using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai07_HocTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soGiay;

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            soGiay = int.Parse(txtNhapGiay.Text);
            lblSoDem.Text = txtNhapGiay.Text;
        }

        private void btnDemNguoc_Click(object sender, EventArgs e)
        {
            timDem.Enabled = true;
            txtNhapGiay.Enabled = false;
            btnXacNhan.Enabled = false;
        }

        private void timDem_Tick(object sender, EventArgs e)
        {
            if (soGiay <= 0)
            {
                soGiay = 0;
                timDem.Enabled = false;
            }
            else
            {
                soGiay = soGiay - 1;
                lblSoDem.Text = soGiay.ToString();
            }
        }
    }
}
