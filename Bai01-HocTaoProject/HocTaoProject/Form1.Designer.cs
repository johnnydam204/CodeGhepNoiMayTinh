namespace HocTaoProject
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
            this.btnXinChao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXinChao
            // 
            this.btnXinChao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXinChao.Location = new System.Drawing.Point(94, 65);
            this.btnXinChao.Name = "btnXinChao";
            this.btnXinChao.Size = new System.Drawing.Size(184, 54);
            this.btnXinChao.TabIndex = 0;
            this.btnXinChao.Text = "Xin chào";
            this.btnXinChao.UseVisualStyleBackColor = true;
            this.btnXinChao.Click += new System.EventHandler(this.btnXinChao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 209);
            this.Controls.Add(this.btnXinChao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXinChao;
    }
}

