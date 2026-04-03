namespace BelediyeAtikUygulamasi
{
    partial class BakimForm
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
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBakimTipi = new System.Windows.Forms.ComboBox();
            this.lblMaliyet = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvBakimlar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeknisyenTC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakimlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARAÇ SEÇİNİZ:";
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(159, 111);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(121, 24);
            this.cmbAraclar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAKIM TÜRÜ:";
            // 
            // cmbBakimTipi
            // 
            this.cmbBakimTipi.FormattingEnabled = true;
            this.cmbBakimTipi.Location = new System.Drawing.Point(159, 168);
            this.cmbBakimTipi.Name = "cmbBakimTipi";
            this.cmbBakimTipi.Size = new System.Drawing.Size(121, 24);
            this.cmbBakimTipi.TabIndex = 3;
            this.cmbBakimTipi.SelectedIndexChanged += new System.EventHandler(this.cmbBakimTipi_SelectedIndexChanged);
            // 
            // lblMaliyet
            // 
            this.lblMaliyet.AutoSize = true;
            this.lblMaliyet.Location = new System.Drawing.Point(0, 236);
            this.lblMaliyet.Name = "lblMaliyet";
            this.lblMaliyet.Size = new System.Drawing.Size(142, 16);
            this.lblMaliyet.TabIndex = 4;
            this.lblMaliyet.Text = "BAKIM MALİYETİ: 0 TL";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(210, 226);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 37);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(210, 269);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 36);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "KAYDI SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvBakimlar
            // 
            this.dgvBakimlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBakimlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBakimlar.Location = new System.Drawing.Point(326, 33);
            this.dgvBakimlar.Name = "dgvBakimlar";
            this.dgvBakimlar.RowHeadersWidth = 51;
            this.dgvBakimlar.RowTemplate.Height = 24;
            this.dgvBakimlar.Size = new System.Drawing.Size(472, 414);
            this.dgvBakimlar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "TEKNİSYEN T.C. :";
            // 
            // txtTeknisyenTC
            // 
            this.txtTeknisyenTC.Location = new System.Drawing.Point(158, 62);
            this.txtTeknisyenTC.Name = "txtTeknisyenTC";
            this.txtTeknisyenTC.Size = new System.Drawing.Size(100, 22);
            this.txtTeknisyenTC.TabIndex = 9;
            // 
            // BakimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTeknisyenTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBakimlar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblMaliyet);
            this.Controls.Add(this.cmbBakimTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAraclar);
            this.Controls.Add(this.label1);
            this.Name = "BakimForm";
            this.Text = "BakimForm";
            this.Load += new System.EventHandler(this.BakimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBakimlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBakimTipi;
        private System.Windows.Forms.Label lblMaliyet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvBakimlar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeknisyenTC;
    }
}