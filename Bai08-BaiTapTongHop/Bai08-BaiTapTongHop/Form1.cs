using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai08_BaiTapTongHop
{
    public partial class radioButton2 : Form
    {
        public radioButton2()
        {
            InitializeComponent();
        }

        int soDem;

        private void btnBatDau_Click(object sender, EventArgs e)
        { 
            timDem.Enabled = true;
        }

        private void timDem_Tick(object sender, EventArgs e)
        {
            if (soDem <= 0)
            {
                soDem = 0;
                timDem.Enabled = false;
            }
            else
            {
                soDem--;
                lblSoDem.Text = soDem.ToString();
            }
        }

        private void rad10s_CheckedChanged(object sender, EventArgs e)
        {
            soDem = 10;
            lblSoDem.Text = soDem.ToString();
        }

        private void rad30s_CheckedChanged(object sender, EventArgs e)
        {
            soDem = 30;
            lblSoDem.Text = soDem.ToString();
        }

        private void rad45s_CheckedChanged(object sender, EventArgs e)
        {
            soDem = 45;
            lblSoDem.Text = soDem.ToString();
        }

        private void rad60s_CheckedChanged(object sender, EventArgs e)
        {
            soDem = 60;
            lblSoDem.Text = soDem.ToString();
        }

        private void rad90s_CheckedChanged(object sender, EventArgs e)
        {
            soDem = 90;
            lblSoDem.Text = soDem.ToString();
        }

    }
}
