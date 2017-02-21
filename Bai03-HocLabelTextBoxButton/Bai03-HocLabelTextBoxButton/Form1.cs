using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai03_HocLabelTextBoxButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu nhập vào TextBox
            String ten = txtNhapTen.Text.ToString();
            Int16 tuoi = Convert.ToInt16(txtTuoi.Text);

            // Xuất dữ liệu ra Label
            lblKetQua.Text = ten + "\n" + "Tuổi là: " + tuoi.ToString();
            
        }
    }
}
