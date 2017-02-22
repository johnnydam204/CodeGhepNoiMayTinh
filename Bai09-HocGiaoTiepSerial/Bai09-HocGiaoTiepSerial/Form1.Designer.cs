namespace Bai09_HocGiaoTiepSerial
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
            this.txtNhapDuLieu = new System.Windows.Forms.TextBox();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnNgatKetNoi = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mời nhập chuỗi cần truyền";
            // 
            // txtNhapDuLieu
            // 
            this.txtNhapDuLieu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapDuLieu.Location = new System.Drawing.Point(24, 127);
            this.txtNhapDuLieu.Margin = new System.Windows.Forms.Padding(5);
            this.txtNhapDuLieu.Name = "txtNhapDuLieu";
            this.txtNhapDuLieu.Size = new System.Drawing.Size(462, 30);
            this.txtNhapDuLieu.TabIndex = 1;
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.Location = new System.Drawing.Point(57, 21);
            this.btnKetNoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(125, 41);
            this.btnKetNoi.TabIndex = 2;
            this.btnKetNoi.Text = "KẾT NỐI";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnNgatKetNoi
            // 
            this.btnNgatKetNoi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgatKetNoi.Location = new System.Drawing.Point(262, 21);
            this.btnNgatKetNoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnNgatKetNoi.Name = "btnNgatKetNoi";
            this.btnNgatKetNoi.Size = new System.Drawing.Size(190, 41);
            this.btnNgatKetNoi.TabIndex = 3;
            this.btnNgatKetNoi.Text = "NGẮT KẾT NỐI";
            this.btnNgatKetNoi.UseVisualStyleBackColor = true;
            this.btnNgatKetNoi.Click += new System.EventHandler(this.btnNgatKetNoi_Click);
            // 
            // btnGui
            // 
            this.btnGui.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(57, 197);
            this.btnGui.Margin = new System.Windows.Forms.Padding(5);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(395, 41);
            this.btnGui.TabIndex = 4;
            this.btnGui.Text = "GỬI DỮ LIÊU";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 326);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnNgatKetNoi);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.txtNhapDuLieu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapDuLieu;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnNgatKetNoi;
        private System.Windows.Forms.Button btnGui;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

