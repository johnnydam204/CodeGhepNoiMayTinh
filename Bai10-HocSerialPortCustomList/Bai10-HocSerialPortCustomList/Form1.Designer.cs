namespace Bai10_HocSerialPortCustomList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataSend = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataReceive = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.serialCOM = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT";
            // 
            // cboCom
            // 
            this.cboCom.AllowDrop = true;
            this.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCom.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCom.FormattingEnabled = true;
            this.cboCom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cboCom.Location = new System.Drawing.Point(15, 35);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(88, 29);
            this.cboCom.TabIndex = 1;
            this.cboCom.SelectedIndexChanged += new System.EventHandler(this.cboCom_SelectedIndexChanged);
            // 
            // cboBaud
            // 
            this.cboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaud.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cboBaud.Location = new System.Drawing.Point(118, 35);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(122, 29);
            this.cboBaud.TabIndex = 3;
            this.cboBaud.SelectedIndexChanged += new System.EventHandler(this.cboBaud_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(261, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(152, 31);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Send:";
            // 
            // txtDataSend
            // 
            this.txtDataSend.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataSend.Location = new System.Drawing.Point(16, 104);
            this.txtDataSend.Name = "txtDataSend";
            this.txtDataSend.Size = new System.Drawing.Size(307, 29);
            this.txtDataSend.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Receive:";
            // 
            // txtDataReceive
            // 
            this.txtDataReceive.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataReceive.Location = new System.Drawing.Point(12, 171);
            this.txtDataReceive.Multiline = true;
            this.txtDataReceive.Name = "txtDataReceive";
            this.txtDataReceive.Size = new System.Drawing.Size(400, 150);
            this.txtDataReceive.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(329, 102);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 31);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(12, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Copyright by Johnny Đàm";
            // 
            // serialCOM
            // 
            this.serialCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 342);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtDataReceive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboBaud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serial Data Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataReceive;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serialCOM;
    }
}

