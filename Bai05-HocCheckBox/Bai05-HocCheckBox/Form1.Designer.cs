namespace Bai05_HocCheckBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkPic = new System.Windows.Forms.CheckBox();
            this.chkAVR = new System.Windows.Forms.CheckBox();
            this.chkDienTuCongSuat = new System.Windows.Forms.CheckBox();
            this.chkPLC = new System.Windows.Forms.CheckBox();
            this.chkThietKeMach = new System.Windows.Forms.CheckBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn môn học:";
            // 
            // chkPic
            // 
            this.chkPic.AutoSize = true;
            this.chkPic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPic.Location = new System.Drawing.Point(17, 62);
            this.chkPic.Name = "chkPic";
            this.chkPic.Size = new System.Drawing.Size(160, 25);
            this.chkPic.TabIndex = 1;
            this.chkPic.Text = "Vi điều khiển PIC";
            this.chkPic.UseVisualStyleBackColor = true;
            // 
            // chkAVR
            // 
            this.chkAVR.AutoSize = true;
            this.chkAVR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAVR.Location = new System.Drawing.Point(17, 86);
            this.chkAVR.Name = "chkAVR";
            this.chkAVR.Size = new System.Drawing.Size(166, 25);
            this.chkAVR.TabIndex = 2;
            this.chkAVR.Text = "Vi điều khiển AVR";
            this.chkAVR.UseVisualStyleBackColor = true;
            // 
            // chkDienTuCongSuat
            // 
            this.chkDienTuCongSuat.AutoSize = true;
            this.chkDienTuCongSuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDienTuCongSuat.Location = new System.Drawing.Point(17, 110);
            this.chkDienTuCongSuat.Name = "chkDienTuCongSuat";
            this.chkDienTuCongSuat.Size = new System.Drawing.Size(161, 25);
            this.chkDienTuCongSuat.TabIndex = 3;
            this.chkDienTuCongSuat.Text = "Điện tử công suất";
            this.chkDienTuCongSuat.UseVisualStyleBackColor = true;
            // 
            // chkPLC
            // 
            this.chkPLC.AutoSize = true;
            this.chkPLC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPLC.Location = new System.Drawing.Point(17, 134);
            this.chkPLC.Name = "chkPLC";
            this.chkPLC.Size = new System.Drawing.Size(64, 25);
            this.chkPLC.TabIndex = 4;
            this.chkPLC.Text = "PLC";
            this.chkPLC.UseVisualStyleBackColor = true;
            // 
            // chkThietKeMach
            // 
            this.chkThietKeMach.AutoSize = true;
            this.chkThietKeMach.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThietKeMach.Location = new System.Drawing.Point(17, 158);
            this.chkThietKeMach.Name = "chkThietKeMach";
            this.chkThietKeMach.Size = new System.Drawing.Size(134, 25);
            this.chkThietKeMach.TabIndex = 5;
            this.chkThietKeMach.Text = "Thiết kế mạch";
            this.chkThietKeMach.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(136, 189);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(133, 39);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.ForeColor = System.Drawing.Color.Red;
            this.lblMonHoc.Location = new System.Drawing.Point(17, 236);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(0, 21);
            this.lblMonHoc.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 382);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.chkThietKeMach);
            this.Controls.Add(this.chkPLC);
            this.Controls.Add(this.chkDienTuCongSuat);
            this.Controls.Add(this.chkAVR);
            this.Controls.Add(this.chkPic);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPic;
        private System.Windows.Forms.CheckBox chkAVR;
        private System.Windows.Forms.CheckBox chkDienTuCongSuat;
        private System.Windows.Forms.CheckBox chkPLC;
        private System.Windows.Forms.CheckBox chkThietKeMach;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblMonHoc;
    }
}

