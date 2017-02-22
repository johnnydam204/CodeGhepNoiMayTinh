using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai09_HocGiaoTiepSerial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnNgatKetNoi.Enabled = false;
            txtNhapDuLieu.Enabled = false;
            btnGui.Enabled = false;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(txtNhapDuLieu.Text.ToString());
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                btnKetNoi.Enabled = false;
                btnNgatKetNoi.Enabled = true;
                txtNhapDuLieu.Enabled = true;
                btnGui.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Cổng kết nối không tồn tại hoặc đã đươc mở", "Thông báo");
            }
        }

        private void btnNgatKetNoi_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btnKetNoi.Enabled = true;
            btnNgatKetNoi.Enabled = false;
            txtNhapDuLieu.Enabled = false;
            btnGui.Enabled = false;
        }

    }
}
