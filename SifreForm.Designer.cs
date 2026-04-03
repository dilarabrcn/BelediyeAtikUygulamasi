namespace BelediyeAtikUygulamasi
{
    partial class SifreForm
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
            this.lblSifreY = new System.Windows.Forms.Label();
            this.txtSifreY = new System.Windows.Forms.TextBox();
            this.btnGirisY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifreY
            // 
            this.lblSifreY.AutoSize = true;
            this.lblSifreY.Location = new System.Drawing.Point(111, 168);
            this.lblSifreY.Name = "lblSifreY";
            this.lblSifreY.Size = new System.Drawing.Size(186, 16);
            this.lblSifreY.TabIndex = 0;
            this.lblSifreY.Text = "YÖNETİCİ ŞİFRESİNİ GİRİNİZ";
            // 
            // txtSifreY
            // 
            this.txtSifreY.Location = new System.Drawing.Point(319, 165);
            this.txtSifreY.Name = "txtSifreY";
            this.txtSifreY.PasswordChar = '*';
            this.txtSifreY.Size = new System.Drawing.Size(220, 22);
            this.txtSifreY.TabIndex = 1;
            // 
            // btnGirisY
            // 
            this.btnGirisY.Location = new System.Drawing.Point(288, 207);
            this.btnGirisY.Name = "btnGirisY";
            this.btnGirisY.Size = new System.Drawing.Size(235, 60);
            this.btnGirisY.TabIndex = 2;
            this.btnGirisY.Text = "GİRİŞ YAP";
            this.btnGirisY.UseVisualStyleBackColor = true;
            this.btnGirisY.Click += new System.EventHandler(this.btnGirisY_Click);
            // 
            // SifreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGirisY);
            this.Controls.Add(this.txtSifreY);
            this.Controls.Add(this.lblSifreY);
            this.Name = "SifreForm";
            this.Text = "SifreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifreY;
        private System.Windows.Forms.TextBox txtSifreY;
        private System.Windows.Forms.Button btnGirisY;
    }
}