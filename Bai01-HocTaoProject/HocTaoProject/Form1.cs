using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HocTaoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXinChao_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Xin chào các bạn!","Thông báo");
            DialogResult dlgThongBao = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgThongBao == System.Windows.Forms.DialogResult.Yes)
            {
                // Thoát chương trình
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Mày còn muốn làm gì nữa", "Hỏi lại");
            }

        }



    }
}
