namespace Bai06_HocRadioButton
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
            this.radRatTuyetVoi = new System.Windows.Forms.RadioButton();
            this.radTuyetVoi = new System.Windows.Forms.RadioButton();
            this.radKhongTotLam = new System.Windows.Forms.RadioButton();
            this.radThayGhe = new System.Windows.Forms.RadioButton();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mời bạn đánh giá khóa học: ";
            // 
            // radRatTuyetVoi
            // 
            this.radRatTuyetVoi.AutoSize = true;
            this.radRatTuyetVoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRatTuyetVoi.Location = new System.Drawing.Point(16, 34);
            this.radRatTuyetVoi.Name = "radRatTuyetVoi";
            this.radRatTuyetVoi.Size = new System.Drawing.Size(103, 23);
            this.radRatTuyetVoi.TabIndex = 1;
            this.radRatTuyetVoi.TabStop = true;
            this.radRatTuyetVoi.Text = "Rất tuyệt vời";
            this.radRatTuyetVoi.UseVisualStyleBackColor = true;
            // 
            // radTuyetVoi
            // 
            this.radTuyetVoi.AutoSize = true;
            this.radTuyetVoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTuyetVoi.Location = new System.Drawing.Point(16, 58);
            this.radTuyetVoi.Name = "radTuyetVoi";
            this.radTuyetVoi.Size = new System.Drawing.Size(82, 23);
            this.radTuyetVoi.TabIndex = 2;
            this.radTuyetVoi.TabStop = true;
            this.radTuyetVoi.Text = "Tuyệt vời";
            this.radTuyetVoi.UseVisualStyleBackColor = true;
            // 
            // radKhongTotLam
            // 
            this.radKhongTotLam.AutoSize = true;
            this.radKhongTotLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhongTotLam.Location = new System.Drawing.Point(16, 82);
            this.radKhongTotLam.Name = "radKhongTotLam";
            this.radKhongTotLam.Size = new System.Drawing.Size(113, 23);
            this.radKhongTotLam.TabIndex = 3;
            this.radKhongTotLam.TabStop = true;
            this.radKhongTotLam.Text = "Không tốt lắm";
            this.radKhongTotLam.UseVisualStyleBackColor = true;
            // 
            // radThayGhe
            // 
            this.radThayGhe.AutoSize = true;
            this.radThayGhe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThayGhe.Location = new System.Drawing.Point(16, 106);
            this.radThayGhe.Name = "radThayGhe";
            this.radThayGhe.Size = new System.Drawing.Size(82, 23);
            this.radThayGhe.TabIndex = 4;
            this.radThayGhe.TabStop = true;
            this.radThayGhe.Text = "Thấy ghê";
            this.radThayGhe.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(94, 135);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(117, 43);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 190);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.radThayGhe);
            this.Controls.Add(this.radKhongTotLam);
            this.Controls.Add(this.radTuyetVoi);
            this.Controls.Add(this.radRatTuyetVoi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radRatTuyetVoi;
        private System.Windows.Forms.RadioButton radTuyetVoi;
        private System.Windows.Forms.RadioButton radKhongTotLam;
        private System.Windows.Forms.RadioButton radThayGhe;
        private System.Windows.Forms.Button btnXacNhan;
    }
}

