namespace Bai08_BaiTapTongHop
{
    partial class radioButton2
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
            this.rad45s = new System.Windows.Forms.RadioButton();
            this.rad30s = new System.Windows.Forms.RadioButton();
            this.rad60s = new System.Windows.Forms.RadioButton();
            this.rad90s = new System.Windows.Forms.RadioButton();
            this.rad10s = new System.Windows.Forms.RadioButton();
            this.lblSoDem = new System.Windows.Forms.Label();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.timDem = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thời gian đếm ngược";
            // 
            // rad45s
            // 
            this.rad45s.AutoSize = true;
            this.rad45s.Location = new System.Drawing.Point(16, 86);
            this.rad45s.Name = "rad45s";
            this.rad45s.Size = new System.Drawing.Size(67, 17);
            this.rad45s.TabIndex = 2;
            this.rad45s.TabStop = true;
            this.rad45s.Text = "Đếm 45s";
            this.rad45s.UseVisualStyleBackColor = true;
            this.rad45s.CheckedChanged += new System.EventHandler(this.rad45s_CheckedChanged);
            // 
            // rad30s
            // 
            this.rad30s.AutoSize = true;
            this.rad30s.Location = new System.Drawing.Point(16, 63);
            this.rad30s.Name = "rad30s";
            this.rad30s.Size = new System.Drawing.Size(67, 17);
            this.rad30s.TabIndex = 3;
            this.rad30s.TabStop = true;
            this.rad30s.Text = "Đếm 30s";
            this.rad30s.UseVisualStyleBackColor = true;
            this.rad30s.CheckedChanged += new System.EventHandler(this.rad30s_CheckedChanged);
            // 
            // rad60s
            // 
            this.rad60s.AutoSize = true;
            this.rad60s.Location = new System.Drawing.Point(16, 110);
            this.rad60s.Name = "rad60s";
            this.rad60s.Size = new System.Drawing.Size(67, 17);
            this.rad60s.TabIndex = 4;
            this.rad60s.TabStop = true;
            this.rad60s.Text = "Đếm 60s";
            this.rad60s.UseVisualStyleBackColor = true;
            this.rad60s.CheckedChanged += new System.EventHandler(this.rad60s_CheckedChanged);
            // 
            // rad90s
            // 
            this.rad90s.AutoSize = true;
            this.rad90s.Location = new System.Drawing.Point(16, 134);
            this.rad90s.Name = "rad90s";
            this.rad90s.Size = new System.Drawing.Size(67, 17);
            this.rad90s.TabIndex = 5;
            this.rad90s.TabStop = true;
            this.rad90s.Text = "Đếm 90s";
            this.rad90s.UseVisualStyleBackColor = true;
            this.rad90s.CheckedChanged += new System.EventHandler(this.rad90s_CheckedChanged);
            // 
            // rad10s
            // 
            this.rad10s.AutoSize = true;
            this.rad10s.Location = new System.Drawing.Point(16, 39);
            this.rad10s.Name = "rad10s";
            this.rad10s.Size = new System.Drawing.Size(67, 17);
            this.rad10s.TabIndex = 1;
            this.rad10s.TabStop = true;
            this.rad10s.Text = "Đếm 10s";
            this.rad10s.UseVisualStyleBackColor = true;
            this.rad10s.CheckedChanged += new System.EventHandler(this.rad10s_CheckedChanged);
            // 
            // lblSoDem
            // 
            this.lblSoDem.AutoSize = true;
            this.lblSoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDem.Location = new System.Drawing.Point(131, 49);
            this.lblSoDem.Name = "lblSoDem";
            this.lblSoDem.Size = new System.Drawing.Size(129, 91);
            this.lblSoDem.TabIndex = 6;
            this.lblSoDem.Text = "00";
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(94, 165);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(107, 33);
            this.btnBatDau.TabIndex = 7;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // timDem
            // 
            this.timDem.Interval = 1000;
            this.timDem.Tick += new System.EventHandler(this.timDem_Tick);
            // 
            // radioButton2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.lblSoDem);
            this.Controls.Add(this.rad90s);
            this.Controls.Add(this.rad60s);
            this.Controls.Add(this.rad30s);
            this.Controls.Add(this.rad45s);
            this.Controls.Add(this.rad10s);
            this.Controls.Add(this.label1);
            this.Name = "radioButton2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad45s;
        private System.Windows.Forms.RadioButton rad30s;
        private System.Windows.Forms.RadioButton rad60s;
        private System.Windows.Forms.RadioButton rad90s;
        private System.Windows.Forms.RadioButton rad10s;
        private System.Windows.Forms.Label lblSoDem;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Timer timDem;
    }
}

