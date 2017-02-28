using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieuKhienTextLCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mnuClose.Enabled = false;
            btnGui.Enabled = false;
            txtChuoiKyTu.Enabled = false;

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            seriCOM.Write(txtChuoiKyTu.Text);
        }

        private void cboComSelectedIndexChanged(object sender, EventArgs e)
        {
            seriCOM.PortName = cboComName.SelectedItem.ToString();
        }

        private void cboBaudSelectedIndexChanged(object sender, EventArgs e)
        {
            seriCOM.BaudRate = int.Parse(cboBaudrate.SelectedItem.ToString());
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            try
            {
                seriCOM.Open();
                mnuComPort.Enabled = false;
                mnuBaudrate.Enabled = false;
                mnuClose.Enabled = true;
                mnuOpen.Enabled = false;
                txtChuoiKyTu.Enabled = true;
                btnGui.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(seriCOM.PortName + " Opent error! \n " + ex.ToString(), "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            seriCOM.Close();
            mnuComPort.Enabled = true;
            mnuBaudrate.Enabled = true;
            mnuClose.Enabled = false;
            mnuOpen.Enabled = true;
            txtChuoiKyTu.Enabled = false;
            btnGui.Enabled = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exitConfirm == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
