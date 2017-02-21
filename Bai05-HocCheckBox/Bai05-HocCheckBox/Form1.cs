using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai05_HocCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            String s = "";
            if (chkAVR.Checked == true)
                s = s + chkAVR.Text + "\n";
            if (chkDienTuCongSuat.Checked == true)
                s = s + chkDienTuCongSuat.Text + "\n";
            if (chkPic.Checked == true)
                s = s + chkPic.Text + "\n";
            if (chkPLC.Checked == true)
                s = s + chkPLC.Text + "\n";
            if (chkThietKeMach.Checked == true)
                s = s + chkThietKeMach.Text + "\n";

            // Hiển thị ra Label
            lblMonHoc.Text = s;
        }

    }
}
