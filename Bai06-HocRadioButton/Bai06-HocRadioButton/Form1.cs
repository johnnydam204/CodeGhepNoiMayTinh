using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai06_HocRadioButton
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
            if (radRatTuyetVoi.Checked == true)
                s = radRatTuyetVoi.Text;
            else if (radTuyetVoi.Checked == true)
                s = radTuyetVoi.Text;
            else if (radKhongTotLam.Checked == true)
                s = radKhongTotLam.Text;
            else if (radThayGhe.Checked == true)
                s = radThayGhe.Text;

            // Hiển thị lên MessageBox
            MessageBox.Show("Bạn đã chọn " + s + "\nXin cảm ơn!", "Thông báo");
        }
    }
}
