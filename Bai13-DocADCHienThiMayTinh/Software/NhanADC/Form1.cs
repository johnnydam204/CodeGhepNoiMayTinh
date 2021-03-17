using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanADC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtADC.Enabled = false;
            txtVoltage.Enabled = false;
        }

        // Truyền Item được chọn trong cboCOM gán vào tên của cổng COM
        private void cboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            seriCOM.PortName = cboCom.SelectedItem.ToString();
        }

        // Truyền Item được chọn trong cboBaud gán vào tốc độ của cổng COM
        private void CboBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            seriCOM.BaudRate = int.Parse(cboBaud.SelectedItem.ToString());
        }

        // Xử lý sự kiện khi nút nhấn btnConnect được nhấn
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnConnect.Text == "CONNECT")
                {
                    seriCOM.Open();
                    btnConnect.Text = "DISCONNECT";
                    txtADC.Enabled = true;
                    txtVoltage.Enabled = true;
                    cboBaud.Enabled = false;
                    cboCom.Enabled = false;
                }
                else if (btnConnect.Text == "DISCONNECT")
                {
                    seriCOM.Close();
                    btnConnect.Text = "CONNECT";
                    txtADC.Enabled = false;
                    txtVoltage.Enabled = false;
                    cboBaud.Enabled = true;
                    cboCom.Enabled = true;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Openning " + seriCOM.PortName + " error \nError code: " + ex.ToString(), 
                    "Info", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        // Hàm xử lý khi có dữ liệu gửi lên cổng COM
        private void xuLyNhanDuLieu(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string duLieuNhan = null;

            // Đọc dữ liệu từ cổng COM
            // Do adc ở mạch gửi lên là 4 ký tự, nên ta xử lý nhận bằng đủ 4 kí tự thì thôi
            do
            {
                duLieuNhan += seriCOM.ReadExisting();
            }                
            while (duLieuNhan.Length <= 4);

            // Do hàm xuLyNhanDuLieu được xử lý ở Luồng khác so với TextBox nên cần có nhượng quyền
            this.BeginInvoke(new xuLyNhuongQuyen(xuLyHienThi), duLieuNhan);
        }

        // Khai báo hàm xử lý nhượng quyền
        private delegate void xuLyNhuongQuyen(string text);

        private void xuLyHienThi(string duLieu)
        {
            int adc;
            double dienAp;
            //voltage = int.Parse(s);
            Int32.TryParse(duLieu, out adc);
            txtADC.Text = duLieu;
            dienAp = adc * (5.0 / 1023.0);
            string chuoiDienAp = Convert.ToString(dienAp);
            try
            {
                string chuoiDienApHienThi = chuoiDienAp.Substring(0,4);
                txtVoltage.Text = chuoiDienApHienThi + " V";
            }
            catch
            {
                txtVoltage.Text = chuoiDienAp + ".00 V";
            }
            txtADC.Text = adc.ToString();
        }
    }
}
