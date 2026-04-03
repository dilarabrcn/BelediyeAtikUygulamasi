namespace BelediyeAtikUygulamasi
{
    partial class MaasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtYoneticiTC = new System.Windows.Forms.TextBox();
            this.btnTumunuOde = new System.Windows.Forms.Button();
            this.dgvMaaslar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaaslar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muhasebe Yöneticisi TC:";
            // 
            // txtYoneticiTC
            // 
            this.txtYoneticiTC.Location = new System.Drawing.Point(174, 29);
            this.txtYoneticiTC.Name = "txtYoneticiTC";
            this.txtYoneticiTC.Size = new System.Drawing.Size(111, 22);
            this.txtYoneticiTC.TabIndex = 1;
            // 
            // btnTumunuOde
            // 
            this.btnTumunuOde.Location = new System.Drawing.Point(15, 190);
            this.btnTumunuOde.Name = "btnTumunuOde";
            this.btnTumunuOde.Size = new System.Drawing.Size(196, 102);
            this.btnTumunuOde.TabIndex = 2;
            this.btnTumunuOde.Text = "TÜM MAAŞLARI ÖDE (TOPLU ÖDEME)";
            this.btnTumunuOde.UseVisualStyleBackColor = true;
            this.btnTumunuOde.Click += new System.EventHandler(this.btnTumunuOde_Click);
            // 
            // dgvMaaslar
            // 
            this.dgvMaaslar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaaslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaaslar.Location = new System.Drawing.Point(317, -1);
            this.dgvMaaslar.Name = "dgvMaaslar";
            this.dgvMaaslar.RowHeadersVisible = false;
            this.dgvMaaslar.RowHeadersWidth = 51;
            this.dgvMaaslar.RowTemplate.Height = 24;
            this.dgvMaaslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaaslar.Size = new System.Drawing.Size(484, 353);
            this.dgvMaaslar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ödeme Ayı:";
            // 
            // cmbAy
            // 
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbAy.Location = new System.Drawing.Point(174, 62);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(121, 24);
            this.cmbAy.TabIndex = 5;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödeme Yılı:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(174, 107);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 22);
            this.txtYil.TabIndex = 7;
            this.txtYil.Text = "2025";
            // 
            // MaasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMaaslar);
            this.Controls.Add(this.btnTumunuOde);
            this.Controls.Add(this.txtYoneticiTC);
            this.Controls.Add(this.label1);
            this.Name = "MaasForm";
            this.Text = "MaasForm";
            this.Click += new System.EventHandler(this.MaasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaaslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYoneticiTC;
        private System.Windows.Forms.Button btnTumunuOde;
        private System.Windows.Forms.DataGridView dgvMaaslar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYil;
    }
}