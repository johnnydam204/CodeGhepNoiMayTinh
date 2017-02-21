namespace Bai07_HocTimer
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
            this.txtNhapGiay = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lblSoDem = new System.Windows.Forms.Label();
            this.btnDemNguoc = new System.Windows.Forms.Button();
            this.timDem = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số giây:";
            // 
            // txtNhapGiay
            // 
            this.txtNhapGiay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapGiay.Location = new System.Drawing.Point(111, 10);
            this.txtNhapGiay.Name = "txtNhapGiay";
            this.txtNhapGiay.Size = new System.Drawing.Size(59, 26);
            this.txtNhapGiay.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(12, 51);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(158, 35);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblSoDem
            // 
            this.lblSoDem.AutoSize = true;
            this.lblSoDem.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDem.Location = new System.Drawing.Point(210, 29);
            this.lblSoDem.Name = "lblSoDem";
            this.lblSoDem.Size = new System.Drawing.Size(144, 97);
            this.lblSoDem.TabIndex = 3;
            this.lblSoDem.Text = "00";
            // 
            // btnDemNguoc
            // 
            this.btnDemNguoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemNguoc.Location = new System.Drawing.Point(12, 110);
            this.btnDemNguoc.Name = "btnDemNguoc";
            this.btnDemNguoc.Size = new System.Drawing.Size(158, 35);
            this.btnDemNguoc.TabIndex = 4;
            this.btnDemNguoc.Text = "ĐẾM NGƯỢC";
            this.btnDemNguoc.UseVisualStyleBackColor = true;
            this.btnDemNguoc.Click += new System.EventHandler(this.btnDemNguoc_Click);
            // 
            // timDem
            // 
            this.timDem.Interval = 1000;
            this.timDem.Tick += new System.EventHandler(this.timDem_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 168);
            this.Controls.Add(this.btnDemNguoc);
            this.Controls.Add(this.lblSoDem);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtNhapGiay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapGiay;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblSoDem;
        private System.Windows.Forms.Button btnDemNguoc;
        private System.Windows.Forms.Timer timDem;
    }
}

