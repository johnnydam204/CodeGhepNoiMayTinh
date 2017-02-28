namespace DieuKhienTextLCD
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
            this.label = new System.Windows.Forms.Label();
            this.txtChuoiKyTu = new System.Windows.Forms.TextBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComPort = new System.Windows.Forms.ToolStripMenuItem();
            this.cboComName = new System.Windows.Forms.ToolStripComboBox();
            this.mnuBaudrate = new System.Windows.Forms.ToolStripMenuItem();
            this.cboBaudrate = new System.Windows.Forms.ToolStripComboBox();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.seriCOM = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(15, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 19);
            this.label.TabIndex = 0;
            this.label.Text = "Nhập chuỗi cần gửi";
            // 
            // txtChuoiKyTu
            // 
            this.txtChuoiKyTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoiKyTu.Location = new System.Drawing.Point(12, 66);
            this.txtChuoiKyTu.Name = "txtChuoiKyTu";
            this.txtChuoiKyTu.Size = new System.Drawing.Size(266, 26);
            this.txtChuoiKyTu.TabIndex = 1;
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(88, 98);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(122, 35);
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "GỬI";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuConnect});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "About";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuConnect
            // 
            this.mnuConnect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuComPort,
            this.mnuBaudrate,
            this.mnuOpen,
            this.mnuClose});
            this.mnuConnect.Name = "mnuConnect";
            this.mnuConnect.Size = new System.Drawing.Size(64, 20);
            this.mnuConnect.Text = "Connect";
            // 
            // mnuComPort
            // 
            this.mnuComPort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboComName});
            this.mnuComPort.Name = "mnuComPort";
            this.mnuComPort.Size = new System.Drawing.Size(152, 22);
            this.mnuComPort.Text = "COMPort";
            // 
            // cboComName
            // 
            this.cboComName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.cboComName.Name = "cboComName";
            this.cboComName.Size = new System.Drawing.Size(121, 23);
            this.cboComName.SelectedIndexChanged += new System.EventHandler(this.cboComSelectedIndexChanged);
            // 
            // mnuBaudrate
            // 
            this.mnuBaudrate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboBaudrate});
            this.mnuBaudrate.Name = "mnuBaudrate";
            this.mnuBaudrate.Size = new System.Drawing.Size(152, 22);
            this.mnuBaudrate.Text = "Baudrate";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudrate.Items.AddRange(new object[] {
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
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 23);
            this.cboBaudrate.SelectedIndexChanged += new System.EventHandler(this.cboBaudSelectedIndexChanged);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(152, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 142);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.txtChuoiKyTu);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Truyền chuỗi ký tự";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtChuoiKyTu;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuComPort;
        private System.Windows.Forms.ToolStripComboBox cboComName;
        private System.Windows.Forms.ToolStripMenuItem mnuBaudrate;
        private System.Windows.Forms.ToolStripComboBox cboBaudrate;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.IO.Ports.SerialPort seriCOM;
    }
}

