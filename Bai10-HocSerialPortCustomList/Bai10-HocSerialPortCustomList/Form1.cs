using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai10_HocSerialPortCustomList
{
    public partial class Form1 : Form
    {
        // Hàm nhượng quyền cho TextBox
        delegate void dataSetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
            txtDataReceive.Enabled = false;
            txtDataSend.Enabled = false;
            btnSend.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(btnConnect.Text == "CONNECT")
            {
                try
                {
                    serialCOM.Open(); 
                    btnConnect.Text = "DISCONNECT";                    
                    txtDataSend.Enabled = true;
                    txtDataReceive.Enabled = true;
                    btnSend.Enabled = true;
                    cboBaud.Enabled = false;
                    cboCom.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("SerialPort open error!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            else if(btnConnect.Text == "DISCONNECT")
            {
                serialCOM.Close();
                btnConnect.Text = "CONNECT";                
                txtDataSend.Enabled = false;
                txtDataReceive.Enabled = false;
                btnSend.Enabled = false;
                cboBaud.Enabled = true;
                cboCom.Enabled = true;
            }

        }

        private void cboCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialCOM.PortName = cboCom.Text;
        }

        private void cboBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialCOM.BaudRate = int.Parse(cboBaud.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            serialCOM.WriteLine(txtDataSend.Text);
        }

        private void dataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String dataRead;
            dataRead = serialCOM.ReadExisting();
            dataSetText(dataRead);
        }

        private void dataSetText(string text)
        {
            if (this.txtDataReceive.InvokeRequired)
            {
                // khởi tạo 1 delegate mới gọi đến SetText
                dataSetTextCallback data = new dataSetTextCallback(dataSetText); 
                this.Invoke(data, new object[] { text });
            }
            else this.txtDataReceive.Text += text;  
        }

    }
}
