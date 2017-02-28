namespace Bai11_DieuKhienLedOnOff
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
            this.chkLed1 = new System.Windows.Forms.CheckBox();
            this.chkLed4 = new System.Windows.Forms.CheckBox();
            this.chkLed2 = new System.Windows.Forms.CheckBox();
            this.chkLed8 = new System.Windows.Forms.CheckBox();
            this.chkLed6 = new System.Windows.Forms.CheckBox();
            this.chkLed5 = new System.Windows.Forms.CheckBox();
            this.chkLed3 = new System.Windows.Forms.CheckBox();
            this.chkLedAll = new System.Windows.Forms.CheckBox();
            this.chkLed7 = new System.Windows.Forms.CheckBox();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.seriCom = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn LED";
            // 
            // chkLed1
            // 
            this.chkLed1.AutoSize = true;
            this.chkLed1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed1.Location = new System.Drawing.Point(22, 115);
            this.chkLed1.Name = "chkLed1";
            this.chkLed1.Size = new System.Drawing.Size(50, 37);
            this.chkLed1.TabIndex = 1;
            this.chkLed1.Text = "LED1";
            this.chkLed1.UseVisualStyleBackColor = true;
            // 
            // chkLed4
            // 
            this.chkLed4.AutoSize = true;
            this.chkLed4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed4.Location = new System.Drawing.Point(208, 115);
            this.chkLed4.Name = "chkLed4";
            this.chkLed4.Size = new System.Drawing.Size(50, 37);
            this.chkLed4.TabIndex = 2;
            this.chkLed4.Text = "LED4";
            this.chkLed4.UseVisualStyleBackColor = true;
            // 
            // chkLed2
            // 
            this.chkLed2.AutoSize = true;
            this.chkLed2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed2.Location = new System.Drawing.Point(84, 115);
            this.chkLed2.Name = "chkLed2";
            this.chkLed2.Size = new System.Drawing.Size(50, 37);
            this.chkLed2.TabIndex = 3;
            this.chkLed2.Text = "LED2";
            this.chkLed2.UseVisualStyleBackColor = true;
            // 
            // chkLed8
            // 
            this.chkLed8.AutoSize = true;
            this.chkLed8.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed8.Location = new System.Drawing.Point(208, 161);
            this.chkLed8.Name = "chkLed8";
            this.chkLed8.Size = new System.Drawing.Size(50, 37);
            this.chkLed8.TabIndex = 6;
            this.chkLed8.Text = "LED8";
            this.chkLed8.UseVisualStyleBackColor = true;
            // 
            // chkLed6
            // 
            this.chkLed6.AutoSize = true;
            this.chkLed6.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed6.Location = new System.Drawing.Point(84, 161);
            this.chkLed6.Name = "chkLed6";
            this.chkLed6.Size = new System.Drawing.Size(50, 37);
            this.chkLed6.TabIndex = 5;
            this.chkLed6.Text = "LED6";
            this.chkLed6.UseVisualStyleBackColor = true;
            // 
            // chkLed5
            // 
            this.chkLed5.AutoSize = true;
            this.chkLed5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed5.Location = new System.Drawing.Point(22, 161);
            this.chkLed5.Name = "chkLed5";
            this.chkLed5.Size = new System.Drawing.Size(50, 37);
            this.chkLed5.TabIndex = 4;
            this.chkLed5.Text = "LED5";
            this.chkLed5.UseVisualStyleBackColor = true;
            // 
            // chkLed3
            // 
            this.chkLed3.AutoSize = true;
            this.chkLed3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed3.Location = new System.Drawing.Point(146, 115);
            this.chkLed3.Name = "chkLed3";
            this.chkLed3.Size = new System.Drawing.Size(50, 37);
            this.chkLed3.TabIndex = 9;
            this.chkLed3.Text = "LED3";
            this.chkLed3.UseVisualStyleBackColor = true;
            // 
            // chkLedAll
            // 
            this.chkLedAll.AutoSize = true;
            this.chkLedAll.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLedAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLedAll.Location = new System.Drawing.Point(276, 115);
            this.chkLedAll.Name = "chkLedAll";
            this.chkLedAll.Size = new System.Drawing.Size(42, 37);
            this.chkLedAll.TabIndex = 8;
            this.chkLedAll.Text = "ALL";
            this.chkLedAll.UseVisualStyleBackColor = true;
            // 
            // chkLed7
            // 
            this.chkLed7.AutoSize = true;
            this.chkLed7.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkLed7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLed7.Location = new System.Drawing.Point(146, 160);
            this.chkLed7.Name = "chkLed7";
            this.chkLed7.Size = new System.Drawing.Size(50, 37);
            this.chkLed7.TabIndex = 7;
            this.chkLed7.Text = "LED7";
            this.chkLed7.UseVisualStyleBackColor = true;
            // 
            // cboCom
            // 
            this.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cboCom.Location = new System.Drawing.Point(16, 38);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(81, 27);
            this.cboCom.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chọn Cổng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Chọn Baudrate";
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaudrate.FormattingEnabled = true;
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
            this.cboBaudrate.Location = new System.Drawing.Point(120, 38);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(103, 27);
            this.cboBaudrate.TabIndex = 12;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(239, 38);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 27);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Location = new System.Drawing.Point(269, 165);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(65, 27);
            this.btnOn.TabIndex = 15;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 206);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboBaudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCom);
            this.Controls.Add(this.chkLed3);
            this.Controls.Add(this.chkLedAll);
            this.Controls.Add(this.chkLed7);
            this.Controls.Add(this.chkLed8);
            this.Controls.Add(this.chkLed6);
            this.Controls.Add(this.chkLed5);
            this.Controls.Add(this.chkLed2);
            this.Controls.Add(this.chkLed4);
            this.Controls.Add(this.chkLed1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLed1;
        private System.Windows.Forms.CheckBox chkLed4;
        private System.Windows.Forms.CheckBox chkLed2;
        private System.Windows.Forms.CheckBox chkLed8;
        private System.Windows.Forms.CheckBox chkLed6;
        private System.Windows.Forms.CheckBox chkLed5;
        private System.Windows.Forms.CheckBox chkLed3;
        private System.Windows.Forms.CheckBox chkLedAll;
        private System.Windows.Forms.CheckBox chkLed7;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOn;
        private System.IO.Ports.SerialPort seriCom;
    }
}

