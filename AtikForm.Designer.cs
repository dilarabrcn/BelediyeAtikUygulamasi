namespace BelediyeAtikUygulamasi
{
    partial class AtikForm
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
            this.lblAtikTuru = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.cmbAtikTuru = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgvAtiklar = new System.Windows.Forms.DataGridView();
            this.lblVerimOrani = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtiklar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Seçiniz:";
            // 
            // lblAtikTuru
            // 
            this.lblAtikTuru.AutoSize = true;
            this.lblAtikTuru.Location = new System.Drawing.Point(12, 63);
            this.lblAtikTuru.Name = "lblAtikTuru";
            this.lblAtikTuru.Size = new System.Drawing.Size(62, 16);
            this.lblAtikTuru.TabIndex = 1;
            this.lblAtikTuru.Text = "Atık Türü:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(12, 130);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(72, 16);
            this.lblMiktar.TabIndex = 2;
            this.lblMiktar.Text = "Miktar (KG)";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapasite.Location = new System.Drawing.Point(292, 9);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(300, 25);
            this.lblKapasite.TabIndex = 3;
            this.lblKapasite.Text = "Doluluk Durumu: 0/50.000 KG";
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(108, 16);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(121, 24);
            this.cmbAraclar.TabIndex = 8;
            // 
            // cmbAtikTuru
            // 
            this.cmbAtikTuru.FormattingEnabled = true;
            this.cmbAtikTuru.Location = new System.Drawing.Point(108, 60);
            this.cmbAtikTuru.Name = "cmbAtikTuru";
            this.cmbAtikTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbAtikTuru.TabIndex = 9;
            this.cmbAtikTuru.SelectedIndexChanged += new System.EventHandler(this.cmbAtikTuru_SelectedIndexChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(108, 124);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(93, 184);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(136, 30);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgvAtiklar
            // 
            this.dgvAtiklar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtiklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtiklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtiklar.Location = new System.Drawing.Point(250, 44);
            this.dgvAtiklar.Name = "dgvAtiklar";
            this.dgvAtiklar.RowHeadersVisible = false;
            this.dgvAtiklar.RowHeadersWidth = 51;
            this.dgvAtiklar.RowTemplate.Height = 24;
            this.dgvAtiklar.Size = new System.Drawing.Size(551, 307);
            this.dgvAtiklar.TabIndex = 11;
            // 
            // lblVerimOrani
            // 
            this.lblVerimOrani.AutoSize = true;
            this.lblVerimOrani.Location = new System.Drawing.Point(12, 94);
            this.lblVerimOrani.Name = "lblVerimOrani";
            this.lblVerimOrani.Size = new System.Drawing.Size(92, 16);
            this.lblVerimOrani.TabIndex = 12;
            this.lblVerimOrani.Text = "Verim Oranı:---";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(93, 232);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 36);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SEÇİLİ KAYDI SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // AtikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblVerimOrani);
            this.Controls.Add(this.dgvAtiklar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbAtikTuru);
            this.Controls.Add(this.cmbAraclar);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblAtikTuru);
            this.Controls.Add(this.label1);
            this.Name = "AtikForm";
            this.Text = "AtikForm";
            this.Load += new System.EventHandler(this.AtikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtiklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAtikTuru;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.ComboBox cmbAraclar;
        private System.Windows.Forms.ComboBox cmbAtikTuru;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgvAtiklar;
        private System.Windows.Forms.Label lblVerimOrani;
        private System.Windows.Forms.Button btnSil;
    }
}